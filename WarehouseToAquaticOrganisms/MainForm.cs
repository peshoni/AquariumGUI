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
        //  private MakeDeliveryControl _supplyControl;
        private SalesMasterDetailControl _salesControl;
        private ShowCompaniesControl _companyesControl;
        private ShowPersonsControl _persondControl;
        private ShowProvidersControl _providersControl;
         

        private PersonManager _personManager ;
        private CompanyManager _clientCompanyManager;
        private CompanyManager _proviederCompanyManager;
        private DeliveryManager _deliveryManager;
        private SaleManager _saleManager;

        private DeliveryMasterDetailControl _masterDetailControl;
        private Control currentControl;
         

        public MainForm()
        {
           Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg");

            InitializeComponent();  
            CreateDBManagers(); 
            CreateControls();

            progresTimer = new System.Windows.Forms.Timer();
            progresTimer.Tick += new EventHandler(this.incrementProgresBar);
            progresTimer.Interval = (50);
            
          progresTimer.Enabled = true;
          //  progresTimer.Start();
            progressBar1.Maximum = 500;

        }

        private void incrementProgresBar( object sender, EventArgs e )
        {
            if (progressBar1.Value <= 500)
            {
                progressBar1.Increment(10);
            }
            else {
                progresTimer.Stop();
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

      

        private void menuClick( object sender, EventArgs e ) {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
           
            switch (item.Name)
            {       // menu Companies: shows all companies in grid.
                case "companyesToolStripMenuItem":
                    disposeAllExceptThisControl(_companyesControl);
                    currentControl = _companyesControl;
                    break; 
                    // Menu Providers: shows all providers in grid.
                case "providersToolStripMenuItem":
                    disposeAllExceptThisControl(_providersControl);
                    currentControl = _providersControl;
                    break;
                    //Menu Persons -  shows all persons in grid
                case "pERSONToolStripMenuItem":
                    disposeAllExceptThisControl(_persondControl);
                    currentControl = _persondControl;
                    break;
                case "makeSaleToolStripMenuItem":
                    disposeAllExceptThisControl(_salesControl);
                    currentControl = _salesControl;
                    break;
                case "createSupplyToolStripMenuItem":
                    disposeAllExceptThisControl(_masterDetailControl);
                    currentControl = _masterDetailControl;
                    break;
                case "insertNewPersonToolStripMenuItem":
                    FormPerson form = new FormPerson(_personManager, _persondControl);
                    form.ShowDialog(this);
                    break;
                case "insertNewCompanyToolStripMenuItem":
                    FormCompany formCom = new FormCompany(_clientCompanyManager, _companyesControl);
                    formCom.ShowDialog(this);
                    break;
                case "addNewProviderToolStripMenuItem":
                    FormCompany formForProviders = new FormCompany(_proviederCompanyManager, _providersControl);
                    formForProviders.ShowDialog(this);
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
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void changeToEN_click( object sender, EventArgs e )
        { 
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            buttonBG.Enabled = true;
            buttonEN.Enabled = false;
            this.Controls.Clear();
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
