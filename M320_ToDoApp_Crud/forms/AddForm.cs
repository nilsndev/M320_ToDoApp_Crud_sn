using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M320_ToDoApp_Crud.classes;

namespace M320_ToDoApp_Crud.forms
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void add_butt_Click(object sender, EventArgs e){
            DataSettings.ToDoes.Add(new ToDo(){
                Name = this.name_tb1.Text,
                Description = this.description_tb.Text,
                ExpiryDate = this.dateTimePicker1.Value
            }); 
            this.DialogResult = DialogResult.OK;

        }
    }
}
