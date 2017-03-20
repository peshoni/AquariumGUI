using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseToAquaticOrganisms.Classes;
using WarehouseToAquaticOrganisms.DBClasses;

namespace WarehouseToAquaticOrganisms
{
    public partial class FormCompany : Form
    {
        private CompanyManager _manager;
        private Company _company = null;
        private UserControl _dataGrid;
        private bool isNewObject; 
        
        /// <summary>
        /// Constructor for adding new object.
        /// </summary>
        /// <param name="manager">Manager which will process object</param>
        public FormCompany( CompanyManager manager, UserControl control )
        {
            InitializeComponent();
            _company = new Company();
            _manager = manager;
            
            _dataGrid = control;  
            isNewObject = true;
        }
        /// <summary>
        /// Constructor for updating some <Person>.
        /// </summary>
        /// <param name="person"><Person> for processing.</param>
        /// <param name="manager">Manager which will process object <Person></param>
        public FormCompany( Company company, CompanyManager manager, UserControl control )
        {
            InitializeComponent();
            _manager = manager;
            _company = company;
            _dataGrid = control; 
            FillTexBoxesFromCompany(_company);
            isNewObject = false; 
        }
        /// <summary>
        /// Loads field from parameter Person.
        /// </summary>
        /// <param name="_person"></param>
        private void FillTexBoxesFromCompany( Company _company )
        { 
            textBoxName.Text = _company.Name;
            textBoxBulstat.Text = _company.Bulstat;
            textBoxAccPerson.Text = _company.AcountablePerson;
            textBoxAddress.Text = _company.Address;
            textBoxPhone.Text = _company.PhoneNumber;
        }
        private void buttonSave_Click( object sender, EventArgs e )
        {
            switch (isNewObject)
            {
                case true: 
                    _company.Name = textBoxName.Text; 
                    _company.Bulstat = textBoxBulstat.Text;
                    _company.AcountablePerson = textBoxAccPerson.Text;
                    _company.Address = textBoxAddress.Text;
                    _company.PhoneNumber = textBoxPhone.Text;
                    _manager.Add(_company);
                    this.Dispose();
                    break;
                case false:
                    _company.Name = textBoxName.Text;
                    //  int res;
                    //  int.TryParse(textBoxEGN.Text, out res);
                    _company.Bulstat = textBoxBulstat.Text;
                    _company.AcountablePerson = textBoxAccPerson.Text;
                    _company.Address = textBoxAddress.Text;
                    _company.PhoneNumber = textBoxPhone.Text;

                    _manager.updateObjectPropertiesIntoDB(_company);
                    _manager.updateList();
                    this.Dispose(); 
                    break;
                default:
                    break;
            }
            _dataGrid.Refresh();
           
            Dispose();
        }
    }
}
