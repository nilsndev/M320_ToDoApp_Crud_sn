using M320_ToDoApp_Crud.classes;
using M320_ToDoApp_Crud.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M320_ToDoApp_Crud.forms
{
    public partial class ViewSingleToDo : Form{
        int _activeIndex = 0;
        OwnMessagebox owmb;
        public ViewSingleToDo(ToDo activeToDO, int activeIndex){
            InitializeComponent();
            this.name_tb1.Text = activeToDO.Name;
            this.description_tb.Text = activeToDO.Description;
            this.expiryDate_tb.Text = activeToDO.ExpiryDate.ToString("yyyy:MM:dd");
            _activeIndex = activeIndex;
            this.id_lbl.Text = activeIndex.ToString();
        }
        private void close_butt1_Click(object sender, EventArgs e){
            this.Close();
        }

        private void ViewSingleToDo_Load(object sender, EventArgs e)
        {
        }

        private void delete_butt1_Click(object sender, EventArgs e){
            string message;
            Image img;
            if(this.id_lbl.Text == ""){
                message = "Die Form wurde noch nicht vollständig geladen wir bitten um Gedud kein stress";
                img = Resources.warining_icon;
                owmb = new OwnMessagebox(message,img);
                owmb.ShowDialog();
                return;
            }
            M320_ToDoApp_Crud.classes.Settings.ToDoes.RemoveAt(_activeIndex);
            this.DialogResult = DialogResult.OK;

        }
    }
}
