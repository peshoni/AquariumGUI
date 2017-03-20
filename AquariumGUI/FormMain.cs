using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aquarium;
using Aquarium.Residents;

namespace AquariumGUI
{
    public partial class FormMain : Form
    {
        private Aquarium.Aquarium aquarium;
        private Bitmap drawArea;
        private Image imgFish;
        private Image imgCrab;
        private Image imgBubble;
        private Image imgSpirogira;
        private Image back;
        private Image image;
        private Graphics graphics; 
        private int widthOfPictureBox;
        private int heightOfPictureBox;
        private const int MARGIN = 60;
        private List<MoveManager> listWithMovingObjects;
        private AddAnimalForm addingAnimalForm;
        private DataGridForm dataGridForm;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Timer aeroTimer;  
        private bool isLightOn = true;
        private const int MaximumLevelOFOxigen=500; 


        #region Getters and setters
        public int WidthOfPictureBox
        {
            get
            {
                return widthOfPictureBox;
            }

            set
            {
                widthOfPictureBox = value;
            }
        }

        public int HeightOfPictureBox
        {
            get
            {
                return heightOfPictureBox;
            }

            set
            {
                heightOfPictureBox = value;
            }
        }

        internal List<MoveManager> ListWithMovingObjects
        {
            get
            {
                return listWithMovingObjects;
            }

            set
            {
                listWithMovingObjects = value;
            }
        }

        public DataGridForm DataGridForm
        {
            get
            {
                return dataGridForm;
            }

            set
            {
                dataGridForm = value;
            }
        }
        #endregion
        public FormMain()
        { 
            InitializeComponent();
            aquarium = new Aquarium.Aquarium(1000, false, 35.5f, 0.25f, MaximumLevelOFOxigen);
            aquarium.MyList.ConnectionString = DBUtill.GetConnectionString();
            aquarium.MyList.SelectAllObjectsFromDB();


            DataGridForm = new DataGridForm(this, aquarium); 
            progressBar1.Value = aquarium.OxigenLevel;
            addLabelsText();
            loadImages();
           
            WidthOfPictureBox = pictureBox1.Width;
            HeightOfPictureBox = pictureBox1.Height;
            drawArea = new Bitmap(WidthOfPictureBox, HeightOfPictureBox);
            ListWithMovingObjects = new List<MoveManager>(); 
            animateLoadedObjects(); 
            drawImage(); 


            moveTimer =  new System.Windows.Forms.Timer();
            moveTimer.Tick += new EventHandler(swimTimer);
            moveTimer.Interval = (300)  ;             
            moveTimer.Enabled = true;                        
            moveTimer.Start();  

            aeroTimer = new System.Windows.Forms.Timer();
            aeroTimer.Tick += new EventHandler(aeroTimerEvent);
            aeroTimer.Interval = (200);              
            aeroTimer.Enabled = false; 
        }

       


        /// <summary>
        /// Timer that invokes auto move method in all objects in list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void swimTimer( object sender, EventArgs e )
        {
            ListWithMovingObjects.ForEach(element =>          
          {
              if (element.Organism != null)
              {
                  if (element.Organism.IsMovable)
                  {
                      element.auto();
                      drawImage();
                  }
              } else {
                   element.auto();
                   drawImage();
               }          
            });
        }
       
        /// <summary>
        /// Loads images from resources.
        /// </summary>
        private void loadImages()
        {
            imgSpirogira = AquariumGUI.Properties.Resources.seaWeed; 
            imgFish = AquariumGUI.Properties.Resources.fish;
            imgCrab = AquariumGUI.Properties.Resources.crab;
            imgBubble = AquariumGUI.Properties.Resources.bubbles;
            back = AquariumGUI.Properties.Resources.back; 
        }
        private void addLabelsText()
        {
            labelFish.Text = labels.Fish; 
            labelShellfish.Text = labels.Shellfish; 
            labelSeaweeds.Text = labels.Seaweeds; 
            buttonCreateObject.Text = labels.Custom;
            buttonOpenGridForm.Text = labels.OpenGridForm;
            groupBox1.Text = labels.aerator;
            buttonAeratorOn.Text = labels.on;
            buttonAeratorOff.Text = labels.off;
            groupBox2.Text = labels.Light;
            buttonLightTurnOf.Text = labels.off;
            buttonTurnLightOn.Text = labels.on; 
        }
        #region Increase buttons
        private void buttonIncreaseFish_Click( object sender, EventArgs e )
        {           
            Goldfish fish = Activator.CreateInstance<Goldfish>();
            fish.Name = "";
            fish.IsMovable = true; 
            addToAquariumLists(fish);
            animateObject(fish, imgFish, WidthOfPictureBox, HeightOfPictureBox);  
        }   

        private void buttonIncreaseShellfish_Click( object sender, EventArgs e )
        { 
            Crab crab =  Activator.CreateInstance<Crab>();
            crab.Name = ""; 
            crab.IsMovable = true;             
            addToAquariumLists(crab);
            animateObject(crab, imgCrab, WidthOfPictureBox, HeightOfPictureBox ); 
        }
        private void buttonIncreaseSeaweed_Click( object sender, EventArgs e )
        {
            Spirogira spiro = Activator.CreateInstance<Spirogira>();
            spiro.Name = "";
            spiro.IsMovable = false;
            addToAquariumLists(spiro);   
            animateObject(spiro,imgSpirogira,WidthOfPictureBox,HeightOfPictureBox ); 
        }
        /// <summary>
        /// Adds to the lists in logic classes.
        /// </summary>
        /// <param name="aquaticOrganism"></param>
        public void addToAquariumLists( AquaticOrganism aquaticOrganism )
        {
            if (aquaticOrganism != null)
            {
                aquarium.addOrganism(aquaticOrganism);
              //  listWithMovingObjects
                refreshTextBosesWithCounters();               
                if (aquarium.OxigenLevel>=MaximumLevelOFOxigen)
                {
                    progressBar1.Value = progressBar1.Maximum;
                }
                DataGridForm.refreshBindingList();
            } 
        }

       
        /// <summary>
        /// Animates some aquatic objects..
        /// </summary>
        /// <param name="aquaticOrganism"> </param>
        /// <param name="image"></param>
        /// <param name="widthOfPictureBox"></param>
        /// <param name="heightOfPictureBox"></param>
        /// <param name="stepInPixels"></param>
        public void animateObject( AquaticOrganism aquaticOrganism, Image image, int widthOfPictureBox, int heightOfPictureBox )
        { 
            ListWithMovingObjects.Add(new MoveManager(image, widthOfPictureBox, heightOfPictureBox, aquaticOrganism));
            drawImage();
        }
        #endregion
        #region Decrease buttons
        private void buttonReduceFish_Click( object sender, EventArgs e )
        {            
            if (aquarium.MyList.countFish()>0) {
                aquarium.MyList.removeFirstOrDefaultObjectOfType(typeof(Fish));                
                refreshTextBosesWithCounters();
                MoveManager elem = ListWithMovingObjects.FirstOrDefault(element => element.Organism.GetType().BaseType.Equals(typeof(Fish)));
                ListWithMovingObjects.Remove(elem);
                drawImage(); 
                DataGridForm.refreshBindingList(); 
            }            
        }
        private void buttonReduceShellfish_Click( object sender, EventArgs e )
        {
            if (aquarium.MyList.countShellfish() > 0) {
                aquarium.MyList.removeFirstOrDefaultObjectOfType(typeof(Shellfish)); 
                refreshTextBosesWithCounters();
                MoveManager elem = ListWithMovingObjects.FirstOrDefault(element => element.Organism.GetType().BaseType.Equals(typeof(Shellfish)));
                ListWithMovingObjects.Remove(elem);
                drawImage();
                DataGridForm.refreshBindingList(); 
            }
        }
        private void buttonReduceSeaweed_Click( object sender, EventArgs e )
        {
            if (aquarium.MyList.countSeaweed()>0) {
                aquarium.MyList.removeFirstOrDefaultObjectOfType(typeof(Seaweed)); 
                refreshTextBosesWithCounters();
                MoveManager elem = ListWithMovingObjects.FirstOrDefault(element => element.Organism.GetType().BaseType.Equals(typeof(Seaweed)));
                ListWithMovingObjects.Remove(elem);
                drawImage();
                DataGridForm .refreshBindingList(); 
            }
        }
        #endregion
        /// <summary>
        /// Getter method for count of residents.
        /// </summary>
        public void refreshTextBosesWithCounters()
        {
            textBoxFishCount.Text = aquarium.MyList.countFish().ToString(); 
            textBoxShellfishCount.Text = aquarium.MyList.countShellfish().ToString(); 
            textBoxSeaweedsCount.Text = aquarium.MyList.countSeaweed().ToString(); 
        }

        #region Aerator 
        /// <summary>
        /// Turn on aerator..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAerator_Click_TurnOn( object sender, EventArgs e )
        { 
            buttonAeratorOff.Enabled = true;
            buttonAeratorOn.Enabled = false;
            aeroTimer.Enabled = true;
            aeroTimer.Start(); 
            MoveManager aero = new MoveManager(imgBubble, widthOfPictureBox, heightOfPictureBox, 38); 
            listWithMovingObjects.Add(aero);
        }
        /// <summary>
        /// Turn off aerator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAerator_Click_TurnOf( object sender, EventArgs e )
        {
            buttonAeratorOff.Enabled = false;
            buttonAeratorOn.Enabled = true;           
            aeroTimer.Enabled = false;
            aeroTimer.Stop();
            MoveManager elem = ListWithMovingObjects.FirstOrDefault(element => element.IsAerator);
            ListWithMovingObjects.Remove(elem); 
        }
        private void aeroTimerEvent( object sender, EventArgs e )
        {
            aquarium.increaseOxigenLevel(10);
            using (graphics = Graphics.FromImage(drawArea))
                graphics.DrawImage(imgBubble, 20, 20);
            int level = aquarium.OxigenLevel;
            if (level <= MaximumLevelOFOxigen)
            {
                progressBar1.Value = aquarium.OxigenLevel;
            }
           
        }
        #endregion
        /// <summary>
        /// Draw all image.
        /// </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void drawImage()
        {
            using (graphics = Graphics.FromImage(drawArea))
            {
                graphics.DrawImage(back, 0, 0);
                ListWithMovingObjects.ForEach(element => {
                    graphics.DrawImage(element.Image, element.XPosition, element.YPosition);
                }); 
                if (!isLightOn)
                {
                    using (Graphics g = Graphics.FromImage(drawArea))
                    {
                        using (Brush brush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                        {
                            g.FillRectangle(brush, 0, 0, widthOfPictureBox, heightOfPictureBox);
                        }
                    }
                } 
                pictureBox1.Image = drawArea;
            }
            int value = aquarium.decreaseOxigenLevel(1);
            if (value >= 1)
            {
                progressBar1.Value = value;
            }
        } 

        /// <summary>
        /// Open new form for creating specific object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateObject_Click( object sender, EventArgs e )
        {
            addingAnimalForm = new AddAnimalForm(this);
            addingAnimalForm.Focus();
            addingAnimalForm.ShowDialog();
        }

     
        /// <summary>
        /// Open GridForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenGridForm_Click( object sender, EventArgs e )
        {
            buttonOpenGridForm.Enabled = false;    
            DataGridForm.Show();
        }
        /// <summary>
        /// Turn light
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click_LightTurnOn( object sender, EventArgs e )
        {
            isLightOn = true;
            buttonTurnLightOn.Enabled = false;
            buttonLightTurnOf.Enabled = true;           
        }

        private void button1_Click_LightTurnOf( object sender, EventArgs e )
        {
            isLightOn = false;
            buttonTurnLightOn.Enabled = true;
            buttonLightTurnOf.Enabled = false;
        }
        #region Trash

        /// <summary>
        /// Save current List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //   private void button1_Click_DBConnect( object sender, EventArgs e )
        //     {

        //       aquarium.MyList.SavaAllObjectsInDB(ConnectionString);
        //       this.aquariumTableAdapter.Fill(this.aquariumDatabaseDataSet.Aquarium);

        //using (SqlConnection conn= new SqlConnection(ConnectionString))
        //{
        //    try
        //    {
        //        conn.Open();



        //        aquarium.List.ForEach(element =>
        //        {
        //            string command = "INSERT into Aquarium (Hashcode, Name, Weight, Type, IsMovable) values ('" +
        //            element.Hashcode + "','" + element.Name + "','" + element.Weight + "','" +
        //            element.GetType().AssemblyQualifiedName + "','" + element.IsMovable + "');";
        //            //string command = "INSERT into Aquarium (Hashcode, Name, Weight, Type) values (@hashcode, @name, @weigth, @type);";

        //            SqlCommand cmd = new SqlCommand(command, conn);
        //            //cmd.Parameters.AddWithValue("@hashcode", element.Hashcode);
        //            //cmd.Parameters.AddWithValue("@name", element.Name);
        //            //cmd.Parameters.AddWithValue("@weigth", element.Weight);
        //            //cmd.Parameters.AddWithValue("@type", element.GetType().AssemblyQualifiedName);
        //            cmd.ExecuteNonQuery();
        //        });

        //        //this.aquariumTableAdapter.Fill(this.aquariumDatabaseDataSet.Aquarium); 
        //        //string getAllSqlCommand = "SELECT * from Aquarium";
        //        //SqlCommand cmd2 = new SqlCommand(getAllSqlCommand, conn);
        //        //SqlDataAdapter Data_adapter = new SqlDataAdapter(cmd2.CommandText, conn);
        //        ////  Data_adapter.CreateObjRef()
        //        //Data_adapter.SelectCommand = cmd2;
        //        ////  cmd2.ExecuteNonQuery();
        //        //DataSet dataset = new DataSet();
        //        //Data_adapter.Fill(dataset);


        //        //DataTable table = new DataTable();
        //        //table.Load(cmd2.ExecuteReader());

        //        //string typeOfNewObject = table.Rows [0] ["Type"].ToString();
        //        //bool isMovable = (bool)table.Rows [0] ["IsMovable"];



        //        //Type type = Type.GetType(typeOfNewObject);
        //        ////Activator.CreateInstance(type);
        //        //AquaticOrganism organism = (AquaticOrganism)Activator.CreateInstance(type);
        //        //organism.Name = "FISH FROM BD 2";
        //        //organism.Weight = 1000;
        //        //organism.IsMovable = isMovable;


        //        //listWithMovingObjects.Add(new MoveManager(imgFish, widthOfPictureBox, heightOfPictureBox, 20, organism));
        //        //aquarium.addOrganism(organism);
        //        //drawImage(); 

        //        this.aquariumTableAdapter.Fill(this.aquariumDatabaseDataSet.Aquarium);

        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("Connection error  " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //} 
        //    }



        //        /// <summary>
        //        /// Loads objects from database.
        //        /// </summary>
        //        private void loadObjectsFromDB()
        //        {

        //            string connectionString = DBUtill.GetConnectionString();
        //            // In a using statement, acquire the SqlConnection as a resource.
        //            //
        //            using (SqlConnection con = new SqlConnection(connectionString))
        //            {
        //                //
        //                // Open the SqlConnection.
        //                //
        //                con.Open();
        //                //
        //                // The following code uses an SqlCommand based on the SqlConnection.
        //                //
        //                using (SqlCommand command = new SqlCommand(@"
        //SELECT 
        //    ID
        //    ,Name
        //    ,Weight
        //    ,Type
        //    ,IsMovable
        //FROM Aquarium", con))
        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        var t = Type.GetType(reader.GetString(3));
        //                        var o = (AquaticOrganism)Activator.CreateInstance(t);
        //                        o.Name = reader.GetString(1);
        //                       // o.Weight = reader.GetInt32(2);
        //                        o.IsMovable = reader.GetBoolean(4); 


        //                        switch (o.GetType().BaseType.Name)
        //                        {
        //                            case "Fish":
        //                                image = imgFish;
        //                                break;
        //                            case "Shellfish":
        //                                image = imgCrab;
        //                                break;
        //                            case "Seaweed":
        //                                image = imgSpirogira;
        //                                break;
        //                            default:
        //                                break;
        //                        }
        //                        aquarium.addOrganism(o);
        //                        listWithMovingObjects.Add(new MoveManager(image, widthOfPictureBox, heightOfPictureBox,/* 30,*/ o));
        //                        Thread.Sleep(10);
        //                        DataGridForm.refreshBindingList();
        //                        refreshTextBosesWithCounters();
        //                        //Thread.Sleep(10);
        //                    }
        //                } 
        //            }

        //            //using (SqlConnection conn = new SqlConnection(ConnectionString))
        //            //{
        //            //    try
        //            //    {
        //            //        conn.Open();

        //            //        string getAllSqlCommand = "SELECT * from Aquarium";
        //            //        SqlCommand cmd2 = new SqlCommand(getAllSqlCommand, conn);
        //            //        SqlDataAdapter Data_adapter = new SqlDataAdapter(cmd2.CommandText, conn);


        //            //        Data_adapter.SelectCommand = cmd2;
        //            //        DataSet dataset = new DataSet();
        //            //        Data_adapter.Fill(dataset);

        //            //        DataTable table = new DataTable();
        //            //        table.Load(cmd2.ExecuteReader());

        //            //        //string typeOfNewObject = table.Rows [0] ["Type"].ToString();
        //            //        //bool isMovable = (bool)table.Rows [0] ["IsMovable"];
        //            //        //string name = table.Rows [0] ["Name"].ToString();
        //            //        //int weight = (int)table.Rows [0] ["Weight"];



        //            //        //Type type = Type.GetType(typeOfNewObject);
        //            //        //AquaticOrganism organism = (AquaticOrganism)Activator.CreateInstance(type);

        //            //        //organism.Name = name;
        //            //        //organism.Weight = weight;
        //            //        //organism.IsMovable = isMovable;


        //            //        DataRow [] data = table.Select();

        //            //        string Name ;
        //            //        bool IsM;
        //            //        string TYpeOf;
        //            //        int Weight;


        //            //        foreach (var item in data)
        //            //        { 
        //            //            Name= item ["Name"].ToString();
        //            //            IsM = (bool)item ["IsMovable"];
        //            //            TYpeOf = item ["Type"].ToString();
        //            //            Weight = int.Parse(item ["Weight"].ToString());


        //            //            Type type = Type.GetType(TYpeOf);
        //            //            AquaticOrganism organism = (AquaticOrganism)Activator.CreateInstance(type);

        //            //            switch (organism.GetType().BaseType.Name)
        //            //            {
        //            //                case "Fish":
        //            //                    image = imgFish;
        //            //                    break;
        //            //                case "Shellfish":
        //            //                    image = imgCrab;
        //            //                    break;
        //            //                case "Seaweed":
        //            //                    image = imgSpirogira;
        //            //                    break;
        //            //                default:
        //            //                    break;
        //            //            }

        //            //            organism.Name = Name;
        //            //            organism.Weight = Weight;
        //            //            organism.IsMovable = IsM;

        //            //            listWithMovingObjects.Add(new MoveManager(image, widthOfPictureBox, heightOfPictureBox,/* 30,*/ organism));
        //            //            aquarium.addOrganism(organism); 


        //            //            DataGridForm.refreshBindingList();
        //            //            refreshTextBosesWithCounters();
        //            //            Thread.Sleep(10);
        //            //        }

        //            //        drawImage(); 

        //            //        this.aquariumTableAdapter.Fill(this.aquariumDatabaseDataSet.Aquarium);
        //            //    }
        //            //    catch (SqlException ex)
        //            //    {
        //            //        MessageBox.Show("Connection error  " + ex.Message);
        //            //    }
        //            //    finally
        //            //    {
        //            //        conn.Close();
        //            //    }
        //            //}
        //        }
        #endregion

        private void animateLoadedObjects() { 
            aquarium.MyList.List.ForEach(element=> {
                switch (element.GetType().BaseType.Name)
                {
                    case "Fish":
                        image = imgFish;
                        break;
                    case "Shellfish":
                        image = imgCrab;
                        break;
                    case "Seaweed":
                        image = imgSpirogira;
                        break;
                    default:
                        break;
                }
                animateObject(element, image, widthOfPictureBox, heightOfPictureBox ); 
                Thread.Sleep(10); 
            }); 
            refreshTextBosesWithCounters(); 
        } 

        /// <summary>
        /// Delete all DB records..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///  
        private void buttonDelleteAllRecordsInDB_Click( object sender, EventArgs e )
        { 
                aquarium.MyList.DeleteAllEntrys( );
                aquarium.MyList.List.Clear();
                listWithMovingObjects.Clear();
                refreshTextBosesWithCounters();
                drawImage(); 
                DataGridForm.refreshBindingList(); 
        } 
    }
}
