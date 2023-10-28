namespace M320_ToDoApp_Crud.forms
{
    partial class OwnMessagebox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnMessagebox));
            this.message_lbl = new System.Windows.Forms.Label();
            this.icon_pb = new System.Windows.Forms.PictureBox();
            this.ok_butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icon_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // message_lbl
            // 
            this.message_lbl.Location = new System.Drawing.Point(107, 20);
            this.message_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.message_lbl.Name = "message_lbl";
            this.message_lbl.Size = new System.Drawing.Size(179, 58);
            this.message_lbl.TabIndex = 0;
            this.message_lbl.Text = "-";
            // 
            // icon_pb
            // 
            this.icon_pb.Location = new System.Drawing.Point(9, 10);
            this.icon_pb.Margin = new System.Windows.Forms.Padding(2);
            this.icon_pb.Name = "icon_pb";
            this.icon_pb.Size = new System.Drawing.Size(75, 68);
            this.icon_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_pb.TabIndex = 1;
            this.icon_pb.TabStop = false;
            // 
            // ok_butt
            // 
            this.ok_butt.Location = new System.Drawing.Point(128, 99);
            this.ok_butt.Margin = new System.Windows.Forms.Padding(2);
            this.ok_butt.Name = "ok_butt";
            this.ok_butt.Size = new System.Drawing.Size(94, 37);
            this.ok_butt.TabIndex = 2;
            this.ok_butt.Text = "Ok";
            this.ok_butt.UseVisualStyleBackColor = true;
            this.ok_butt.Click += new System.EventHandler(this.ok_butt_Click);
            // 
            // OwnMessagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 147);
            this.Controls.Add(this.ok_butt);
            this.Controls.Add(this.icon_pb);
            this.Controls.Add(this.message_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OwnMessagebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.SucessMessagebox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label message_lbl;
        private System.Windows.Forms.Button ok_butt;
        public System.Windows.Forms.PictureBox icon_pb;
    }
}