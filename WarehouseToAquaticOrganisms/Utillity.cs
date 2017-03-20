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


        public static DataGridViewButtonColumn createDatagridViewButtonColumn( string aHeader, string aText, string aButtonName )
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Width = 60;
            buttonColumn.HeaderText = aHeader;
            buttonColumn.Text = aText;
            buttonColumn.Name = aButtonName;
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
        /// <param name = "aHeader" ></ param >
        /// < param name= "aText" ></ param >
        /// < param name= "aDataPropertyName" ></ param >
        /// < param name= "dividerWidth" ></ param >
        /// < returns ></ returns >
        public static DataGridViewTextBoxColumn createDatagridViewTextBoxColumn( string aHeader, string aText, string aDataPropertyName, int width, bool aReadOnly )
        {
            DataGridViewTextBoxColumn textBoxColumn = new DataGridViewTextBoxColumn();
          //  textBoxColumn.Width = dividerWidth;
            textBoxColumn.Width = width;
            textBoxColumn.HeaderText = aHeader;
            textBoxColumn.Name = aText;
            textBoxColumn.DataPropertyName = aDataPropertyName;
            textBoxColumn.ReadOnly = aReadOnly;
            return textBoxColumn;
        }
    }
}
