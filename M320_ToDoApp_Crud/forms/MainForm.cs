using M320_ToDoApp_Crud.classes;
using M320_ToDoApp_Crud.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace M320_ToDoApp_Crud.forms{
    public partial class MainForm : Form{
        OwnMessagebox smsb;
        string path = "";
        string errMess = "Es gab einen Fehler: \n";
        public MainForm(){
            InitializeComponent();
        }
        private void update_butt1_Click(object sender, EventArgs e){
            UpdateForm uf;
            try{
                uf = new UpdateForm();
                uf.ShowDialog();
                uf.Dispose();
                this.output_dgv.Refresh();
                if(uf.DialogResult == DialogResult.OK){
                    saveDatainFile_butt_Click(sender, e);
                }
            }
            catch (Exception ex){
                showMSB(errMess + ex.Message, Resources.error_icon);
                MessageBox.Show(ex.Message);
            }
        }
        private void MainForm_Load(object sender, EventArgs e){
            try{
                loadDataFromFile_butt_Click(sender,e);
                connectDGV();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }

        }
        void connectDGV(){
            var descriptionColumn = output_dgv.Columns["Description"];
            this.output_dgv.DataSource =classes.DataSettings.ToDoes;
            if(descriptionColumn != null){
                descriptionColumn.Visible = false;
            }

        }

        private void adButt_Click(object sender, EventArgs e){
            AddForm af = new AddForm();
            af.ShowDialog();
            if(af.DialogResult == DialogResult.OK){
                saveDatainFile_butt_Click(sender, e);
                loadDataFromFile_butt_Click(sender, e);
            }
        }

        private void saveDatainFile_butt_Click(object sender, EventArgs e){
            string txt = "";
            Image img = null;
            try{
                path = Application.StartupPath + "/savedFiles/data.xml";
                StreamWriter sw = new StreamWriter(path);
                XmlSerializer serializer = new XmlSerializer(typeof(List<ToDo>));
                serializer.Serialize(sw, classes.DataSettings.ToDoes);
                sw.Close();
                img = Resources.success_icon;
                txt = "Daten wurden erfolgreich gespeichert";

            }
            catch(Exception ex){
                txt = errMess + ex.Message;
                img = Resources.error_icon;
            }
            finally{
                showMSB(txt, img);
            }
        }
        private void loadDataFromFile_butt_Click(object sender, EventArgs e){
            path = Application.StartupPath + "/savedFiles/data.xml";
            StreamReader sr = new StreamReader(path);
            XmlSerializer serializer = new XmlSerializer(typeof (List<ToDo>));
            classes.DataSettings.ToDoes = (List<ToDo>) serializer.Deserialize(sr);
            sr.Close();
            connectDGV();
        }
        void showMSB(string txt,Image img){
            smsb = new OwnMessagebox(txt,img);
            smsb.ShowDialog();
        }

        private void clear_butt_Click(object sender, EventArgs e){
            this.output_dgv.DataSource = null;
        }

        private void output_dgv_CellClick(object sender, DataGridViewCellEventArgs e){
            try{
                ToDo actElement = M320_ToDoApp_Crud.classes.DataSettings.ToDoes[e.RowIndex];
                ViewSingleToDo vsf = new ViewSingleToDo(actElement,e.RowIndex);
                vsf.ShowDialog();
                if(vsf.DialogResult == DialogResult.OK){
                    //fertig machen
                    saveDatainFile_butt_Click(sender, e);
                    loadDataFromFile_butt_Click(sender, e);
                }
            }catch(Exception ex){
                OwnMessagebox owm = new OwnMessagebox(ex.Message, Resources.error_icon);
                owm.ShowDialog();
            }
            


        }
        private void delete_butt1_Click(object sender, EventArgs e)
        {

        }

        private void output_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void output_dgv_DataError(object sender, DataGridViewDataErrorEventArgs e){
            e.Cancel = true;
            return;
        }
    }
}
