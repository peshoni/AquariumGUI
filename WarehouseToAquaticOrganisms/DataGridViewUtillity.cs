using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseToAquaticOrganisms
{
   public class DataGridViewUtillity
    {
        private DataGridViewUtillity() { }


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

        public static DataGridViewComboBoxColumn createDataGridViewComboboxColumn( string header,object datasource, string dataPropertyName, string displayMember, string valueMember )
        {
            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.HeaderText = header;
            comboColumn.DataSource = datasource;
            comboColumn.DataPropertyName = dataPropertyName;
            comboColumn.DisplayMember = displayMember;
            comboColumn.ValueMember = valueMember;
            comboColumn.ValueType = typeof(int);


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
            textBoxColumn.Name = Name;
            textBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            textBoxColumn.HeaderText = Header;
            textBoxColumn.DataPropertyName = DataPropertyName;
            textBoxColumn.ReadOnly = ReadOnly; 
            return textBoxColumn;
        }

        public static DataGridViewCheckBoxColumn createDataGridViewCheckBoxColumn( string name, string headerText, string propertyName, bool readOnly ) {
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            column.Name = name;
            column.HeaderText = headerText;
            column.DataPropertyName = propertyName;  
            column.ReadOnly =  readOnly ;  
            return column;
        }
        /// <summary>
        /// Setter method for Currency style of DataGridViewTextBox column.
        /// </summary>
        /// <returns><see cref="DataGridViewCellStyle"/></returns>
        public static DataGridViewCellStyle getPriceStyle()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0,00";
            return dataGridViewCellStyle1;
        }
        /// <summary>
        /// Turns AutoGenerateColumns in false state and clears the grid.
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void clearGrid( DataGridView dataGridView )
        {
            if (dataGridView != null)
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.Columns.Clear();
            }
        }
    }
}
