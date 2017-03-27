using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseToAquaticOrganisms.Classes;
using WarehouseToAquaticOrganisms.DBClasses; 
using System.Globalization;

namespace WarehouseToAquaticOrganisms
{
    public partial class SalesControl : UserControl
    {
        private enum TypeOfPartner {Type = 0, Person = 1, Company = 2 }

        /// <summary>
        /// //////////////////////////////////////////////////////////////// opravi kato napravish tablica v bazata
        /// </summary>
     //   private enum Goods { Fish, Crab, Seaweed}
        private PersonManager _personManager;
        private CompanyManager _companyManager;
        private ComboBox personCombo;
        private ComboBox companyCombo;

        private decimal suma;
        private decimal total;
        private System.Drawing.Point hide;

        //private DataGridViewTextBoxColumn textColumnNumberOfRow;
        //private DataGridViewTextBoxColumn textColumnPieces;
        //private DataGridViewTextBoxColumn textColumnPrice;
        //private DataGridViewTextBoxColumn textColumnVAT;        
        //private DataGridViewComboBoxColumn comboWithArticles;
       

        public SalesControl(PersonManager personManager, CompanyManager companyManager)
        {
            InitializeComponent();
         //   RefreshLists();
            _personManager = personManager;
            _companyManager = companyManager;

            comboBox1.DataSource = Enum.GetValues(typeof(TypeOfPartner)); 
            hide = new System.Drawing.Point(-100, -100);
            loadComboBoxes();
            //////////////////////////////////////////////

 
            //CreateTable();
            
            
        }

        //private void CreateTable()
        //{

        //    textColumnNumberOfRow = Utillity.createDatagridViewTextBoxColumn("#", "rowNum", "colRows", 10, true);
        //    textColumnPieces = Utillity.createDatagridViewTextBoxColumn("pieces", "pieces", "colPieces", 10, false);
        //    textColumnPrice = Utillity.createDatagridViewTextBoxColumn("Price", "rowNum", "colPrice", 10, false);
        //    textColumnVAT = Utillity.createDatagridViewTextBoxColumn("VAT", "vatColumn", "colVAT", 30, false);
        //    comboWithArticles = Utillity.createDataGridViewComboboxColumn("TYPE", 40);
        //    dataGridView1.Columns.AddRange(textColumnNumberOfRow, comboWithArticles, textColumnPieces, textColumnPrice, textColumnVAT);
            
        //}

        private void loadComboBoxes()
        {
            personCombo = new ComboBox();
            personCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            personCombo.Location = hide;
         ////   personCombo.Items.Insert(0, "Ivan");
         //   personCombo.Items.Insert(1, "Petko"); 
            this.Controls.Add(personCombo);

            companyCombo = new ComboBox();
            companyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            companyCombo.Location = hide;
         //   companyCombo.Items.Insert(0, "Company 1");
         //   companyCombo.Items.Insert(1, "Company 2"); 
            this.Controls.Add (companyCombo);
        }

        public  void RefreshLists()
        {
            personCombo.DataSource = _personManager;//.List;
            personCombo.DisplayMember = "Name";

            companyCombo.DataSource = _companyManager;//.List;
            companyCombo.DisplayMember = "Name";
        }
        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {
            TypeOfPartner type = (TypeOfPartner)comboBox1.SelectedItem;
           
            switch (type)
            {
                case TypeOfPartner.Person:
                    RefreshLists();
                    //comboBox1.ValueMember = "Name";
                    personCombo.Location = new System.Drawing.Point(comboBox1.Location.X, comboBox1.Location.Y + 40);
                    companyCombo.Location = hide; 
                    break;
                case TypeOfPartner.Company:
                    RefreshLists();
                    companyCombo.Location = new System.Drawing.Point(comboBox1.Location.X, comboBox1.Location.Y + 40);
                    personCombo.Location = hide; 
                    break;
                default:
                    break; 
            }
            this.Update();
            //MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void button1_Click( object sender, EventArgs e )
        {
            //var val = dataGridView1.Rows.Count;// [0].Cells [3].Value.ToString();

            //textBox1.Text = val.ToString();
        }

        private void dataGridView1_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            //int row = e.RowIndex;
            //if (row >= 0)
            //{
            //   // int ID = (int)dataGridView1.Rows [row].Cells ["iDDataGridViewTextBoxColumn"].Value; ;
            //    if (e.ColumnIndex == columnPieces.Index)
            //    {
            //        DataGridViewRow done = dataGridView1.Rows [row];
            //        MessageBox.Show(done.Cells[2].Value.ToString());
            //    }
                
               
            //}
        }

        private void dataGridView1_CellEndEdit( object sender, DataGridViewCellEventArgs e )
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
               
                // int ID = (int)dataGridView1.Rows [row].Cells ["iDDataGridViewTextBoxColumn"].Value; ;
                if (e.ColumnIndex == columnPieces.Index)
                {
                    DataGridViewRow done = dataGridView1.Rows [row];

                    done.Cells [0].Value = row + 1;

                    done.Cells [3].Value = 2.58m;
                    decimal pieces; 
                    decimal.TryParse(done.Cells [2].Value.ToString(),out pieces);

                    decimal price; 
                    decimal.TryParse(done.Cells [3].Value.ToString(), out price);

                    decimal temp = pieces * price;
                    suma += temp;
                    done.Cells [4].Value = temp;

                    total = suma * 1.2m;
                    Math.Round(total, 2);
                    textBox1.Text = suma.ToString();
                    decimal vat = Math.Round((total - suma), 2);
                    textBox2.Text = (vat).ToString();
                    textBox3.Text = /*String.Format(CultureInfo.CurrentCulture, "{0:C0}", Math.Round(total, 2));//*/Math.Round(total, 2).ToString();




                    temp = 0; 
                } 
            }
        }

        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void dataGridView1_CellContentClick_1( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void dataGridView1_CellContentClick_2( object sender, DataGridViewCellEventArgs e )
        {

        }
    }
}
