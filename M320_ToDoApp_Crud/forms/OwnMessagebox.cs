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
    public partial class OwnMessagebox : Form
    {
        public OwnMessagebox(){
            InitializeComponent();
        }
        public OwnMessagebox(string message){
            InitializeComponent();
            this.message_lbl.Text = message;
        }
        public OwnMessagebox(string message,Image img){
            InitializeComponent();
            this.message_lbl.Text = message;
            this.icon_pb.Image = img;
            
        }

        private void SucessMessagebox_Load(object sender, EventArgs e)
        {

        }

        private void ok_butt_Click(object sender, EventArgs e){
            this.DialogResult = DialogResult.OK;

        }
    }
}
