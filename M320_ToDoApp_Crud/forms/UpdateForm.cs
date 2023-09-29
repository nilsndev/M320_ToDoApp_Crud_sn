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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void update_butt1_Click(object sender, EventArgs e){
            string selectedValue;
            DateTime expDate;
            try{
                selectedValue = this.items_cb1.SelectedItem.ToString();
                if (selectedValue == "" || this.name_tb1.Text == "" || this.expDate_tb1.Text == ""){
                    MessageBox.Show("ALle Felder müssen ausgefüllt sein");
                    return;
                }
                expDate = Convert.ToDateTime(this.expDate_tb1.Text);
                for (int i = 0; i < Settings.ToDoes.Count; i++){
                    if (Settings.ToDoes[i].Name == selectedValue){
                        Settings.ToDoes[i].Name = this.name_tb1.Text;
                        Settings.ToDoes[i].ExpiryDate = expDate;
                        MessageBox.Show("Bearbeitung war erfolgreich");
                    }
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }

        }
        private void UpdateForm_Load(object sender, EventArgs e){
            try{
                for (int i = 0; i < Settings.ToDoes.Count; i++){
                    this.items_cb1.Items.Add(Settings.ToDoes[i].Name);
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
