using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseToAquaticOrganisms
{
   public class Utillity
    {
        private Utillity() { }


        public static DataGridViewButtonColumn createDatagridViewButtonColumn( string buttonHeader, string buttonText, string buttonName )
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Width = 60;
            buttonColumn.HeaderText = buttonHeader;
            buttonColumn.Text = buttonText;
            buttonColumn.Name = buttonName;
            buttonColumn.UseColumnTextForButtonValue = true;
            return buttonColumn;
        }

        public static DataGridViewComboBoxColumn createDataGridViewComboboxColumn(string header,int dividerWidth) {
            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.Width = dividerWidth;
            comboColumn.HeaderText = header;


            return comboColumn;
        }
        /// <summary>
        /// Create column with textBoxes..
        /// </summary>
        /// <param name = "Header" ></ param >
        /// < param name= "ColumnName" ></ param >
        /// < param name= "DataPropertyName" ></ param >
        /// < param name= "dividerWidth" ></ param >
        /// < returns ></ returns >
        public static DataGridViewTextBoxColumn createDatagridViewTextBoxColumn( string Header, string Name, string DataPropertyName, bool ReadOnly )
        {
            DataGridViewTextBoxColumn textBoxColumn = new DataGridViewTextBoxColumn();
            //  textBoxColumn.Width = dividerWidth;
            //  textBoxColumn.Width = Width;
            textBoxColumn.Name = Name;
            textBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            textBoxColumn.HeaderText = Header; 
            textBoxColumn.DataPropertyName = DataPropertyName;
            textBoxColumn.ReadOnly = ReadOnly;
            return textBoxColumn;
        }
    }
}
