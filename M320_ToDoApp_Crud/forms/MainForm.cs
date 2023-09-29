using M320_ToDoApp_Crud.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M320_ToDoApp_Crud.forms{
    public partial class MainForm : Form{
        public MainForm(){
            InitializeComponent();
        }

        private void update_butt1_Click(object sender, EventArgs e){
            try{
                UpdateForm uf = new UpdateForm();
                uf.ShowDialog();
                uf.Dispose();
                this.output_dgv.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MainForm_Load(object sender, EventArgs e){
            try{
                //-----Die Zeilen innerhalb dieses Kommentarblockes können später gelöscht werden---------
                Settings.ToDoes.Add(new ToDo() { Name = "test", ExpiryDate = new DateTime(2023, 12, 11) });
                Settings.ToDoes.Add(new ToDo() { Name = "test2", ExpiryDate = new DateTime(2023, 12, 10) });
                //=========================================================================================
                this.output_dgv.DataSource = Settings.ToDoes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
