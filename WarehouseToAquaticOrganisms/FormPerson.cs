using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseToAquaticOrganisms.Classes;
using WarehouseToAquaticOrganisms.DBClasses;
using WareHouseToAquaticOrganisms;

namespace WarehouseToAquaticOrganisms
{
    public partial class FormPerson : Form
    {
        private PersonManager _manager;
        private Person _person = null;
        private ShowPersonsControl _personControl;
        private bool isNewObject;
        /// <summary>
        /// Constructor for adding new object.
        /// </summary>
        /// <param name="manager">Manager which will process object</param>
        public FormPerson(PersonManager manager,ShowPersonsControl personControl)
        {
            InitializeComponent();
            _personControl = personControl;
            this._person = new Person();
            this._manager = manager;
            isNewObject = true;
        }
        /// <summary>
        /// Constructor for updating some <Person>.
        /// </summary>
        /// <param name="person"><Person> for processing.</param>
        /// <param name="manager">Manager which will process object <Person></param>
        public FormPerson(Person person, PersonManager manager, ShowPersonsControl personControl ) {
            InitializeComponent(); 
            _manager = manager;
            _person = person;
            _personControl = personControl;
            getFieldFromPersonObject(_person);
            isNewObject = false;
            
        }
        /// <summary>
        /// Loads field from parameter Person.
        /// </summary>
        /// <param name="_person"></param>
        private void getFieldFromPersonObject( Person _person )
        {
            textBoxName.Text = _person.Name ;
            textBoxEGN.Text = _person.Egn.ToString(); 
            textBoxAddress.Text = _person.Address;
            textBoxPhoneNumber.Text=_person.PhoneNumber;
        }

        private void textPhoneChanged( object sender, EventArgs e )
        {
            throw new NotImplementedException();
        }

        private void textNameChanged( object sender, EventArgs e )
        {
            throw new NotImplementedException();
        }

        private void textEGNChanged( object sender, EventArgs e )
        {
            throw new NotImplementedException();
            //string text = textBoxEGN.Text;
            //string temp;
            //if (text.Length >= 10)
            //{

            //    if (Validator.isValidEGN(text))
            //    {
            //        // textBoxEGN.Text = text;
            //        _valueOfEGN = text;
            //        //     oldValueOfEGN = text;
            //        isEgnEntered = true;
            //        textBoxEGN.BackColor = Color.LightGreen;
            //    }
            //    else
            //    {
            //        System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            //        ToolTip1.SetToolTip(this.textBoxEGN, "Incorect format of EGN");
            //        if (text.Length == 0)
            //        {
            //            _valueOfEGN = "";

            //            isEgnEntered = false;
            //            buttonSave.Enabled = false;
            //        }
            //    //    textBoxEGN.Text = _valueOfEGN;
            //        textBoxEGN.SelectionStart = textBoxEGN.Text.Length;
            //    }
            //}



           // tryEnableSaveButton();
        }

        private void textAddresChanged( object sender, EventArgs e )
        {
            throw new NotImplementedException();
        }
 
        private void tryEnableSaveButton()
        {
            //if (/*indexChanged && */isEgnEntered/* && weightEntered*/)
            //{
            //    buttonSave.Enabled = true;
            //}
        }

        private void buttonSave_Click( object sender, EventArgs e )
        { 
            switch (isNewObject)
            { 
                case true:
                    _person.Name = textBoxName.Text;
                    int res;
                    int.TryParse(textBoxEGN.Text, out res);
                    _person.Egn = res;
                    _person.Address = textBoxAddress.Text;
                    _person.PhoneNumber = textBoxPhoneNumber.Text;  
                    _manager.Add(_person); 

                    break;
                case false:
                    _person.Name = textBoxName.Text;
                    int result;
                    int.TryParse(textBoxEGN.Text, out result);
                    _person.Egn = result;
                    _person.Address = textBoxAddress.Text;
                    _person.PhoneNumber = textBoxPhoneNumber.Text; 
                    _manager.Update(_person); 

                    break;
                default:
                    break;
            }
            _personControl.refreshList();
            Dispose();

        }
    }
}
