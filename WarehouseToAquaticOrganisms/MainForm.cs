using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Observer;
using WarehouseToAquaticOrganisms.Classes;
using WarehouseToAquaticOrganisms.DBClasses;

namespace WarehouseToAquaticOrganisms
{
    public partial class MainForm : Form

    {
        private System.Windows.Forms.Timer progresTimer;
        private DeliveryMasterDetailControl _masterDetailControl;
        private SalesMasterDetailControl _salesControl;
        private ShowCompaniesControl _companyesControl;
        private ShowPersonsControl _persondControl;
        private ShowProvidersControl _providersControl;

        private DeliveryManager _deliveryManager;
        private SaleManager _saleManager;
        private PersonManager _personManager ;
        private CompanyManager _clientCompanyManager;
        private CompanyManager _proviederCompanyManager;
         

        public MainForm()
        {
           Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg");

            InitializeComponent();  
            CreateDBManagers(); 
            CreateControls();

            progresTimer = new System.Windows.Forms.Timer();
            progresTimer.Tick += new EventHandler(this.incrementProgresBar);
            progresTimer.Interval = (1);
          //  progresTimer.Enabled = true;
          //  progresTimer.Start();
            progressBar1.Maximum = 500; 
        }

        private void incrementProgresBar( object sender, EventArgs e )
        {

            if (progressBar1.Value <  500)
            {
                progressBar1.Increment(10);
            }
            if (progressBar1.Value>=500)
            {
                progresTimer.Stop();
                progressBar1.Enabled = false;
                progressBar1.Hide();
            }
             
        }

        private void CreateDBManagers()
        {
            _personManager = new PersonManager();
            _clientCompanyManager = new CompanyManager(false);
            _proviederCompanyManager = new CompanyManager(true);
            _deliveryManager = new DeliveryManager();
            _saleManager = new SaleManager();
        }
        private void CreateControls()
        {
            _salesControl = new SalesMasterDetailControl(_personManager, _clientCompanyManager, _deliveryManager, _saleManager);
            _persondControl = new ShowPersonsControl(_personManager);
            _companyesControl = new ShowCompaniesControl(_clientCompanyManager); 
            _providersControl = new ShowProvidersControl(_proviederCompanyManager);
            _masterDetailControl = new DeliveryMasterDetailControl(_proviederCompanyManager, _deliveryManager);

            Control [] controls = { _salesControl, _persondControl, _companyesControl, _providersControl, _masterDetailControl };
            foreach (var item in controls)
            {
                item.Dock = DockStyle.Fill;
                item.Hide();
                panelMain.Controls.Add(item);
            }
        }
        private void sizeChanged( object sender, EventArgs e ) {
            this.panelMain.Size = this.Size; 
        } 
        private void button_Click( object sender, EventArgs e )
        {
            Button button = ((Button)sender);
            switch ((int)button.Tag)
            {      
                case 0: /* Delivery page */
                    disposeAllExceptThisControl(_masterDetailControl);
                 //   currentControl = _masterDetailControl;
                    break;
                  
                case 1: /* Sales page */
                    disposeAllExceptThisControl(_salesControl);
                   // currentControl = _salesControl;
                    break;
                case 2: /* Providers page */
                    disposeAllExceptThisControl(_providersControl);
                 //   currentControl = _providersControl;
                    break; 

                case 3: /*Clients persons page */
                    disposeAllExceptThisControl(_persondControl);
                 //   currentControl = _persondControl;
                    break;

                case 4: /*Clients companies page */
                    disposeAllExceptThisControl(_companyesControl);
                //    currentControl = _companyesControl;
                    break;

                default:
                 break;
            }
        }
        /// <summary>
        /// Hide all controls except current one which will use.
        /// </summary>
        /// <param name="controlName"></param>
        private void disposeAllExceptThisControl(Control control)
        {
            control.Show();
            foreach (Control item in panelMain.Controls)
            {
                if (!item.Name.Equals(control.Name))
                {
                    item.Hide(); 
                }
            }
        }

        private void changeToBG_click( object sender, EventArgs e )
        { 
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg");
            buttonBG.Enabled = false;
            buttonEN.Enabled = true;
          //  this.Controls.Clear();
            this.InitializeComponent();
        }

        private void changeToEN_click( object sender, EventArgs e )
        { 
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            buttonBG.Enabled = true;
            buttonEN.Enabled = false;
          //  this.Controls.Clear();
            this.InitializeComponent();
        }
        

        private void closeOrNo( object sender, FormClosingEventArgs e )
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    DialogResult result = MessageBox.Show("Изход от програмата", " Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    switch (result)
            //    {
            //        case DialogResult.Yes:
            //            /// Save or close resource /// or show some timer.. progressbar
            //            Dispose();
            //            break;
            //        case DialogResult.No:
            //            //  ? 
            //            break;

            //        default:
            //            break;
            //    }
            //}
        }
 
    }
}
