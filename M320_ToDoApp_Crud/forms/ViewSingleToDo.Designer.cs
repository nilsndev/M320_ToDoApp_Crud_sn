namespace M320_ToDoApp_Crud.forms
{
    partial class ViewSingleToDo
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
            this.info_gb = new System.Windows.Forms.GroupBox();
            this.expiryDate_tb = new System.Windows.Forms.TextBox();
            this.description_lbl = new System.Windows.Forms.Label();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.name_lbl1 = new System.Windows.Forms.Label();
            this.name_tb1 = new System.Windows.Forms.TextBox();
            this.date_tb1 = new System.Windows.Forms.Label();
            this.close_butt1 = new System.Windows.Forms.Button();
            this.id_lbl = new System.Windows.Forms.Label();
            this.delete_butt1 = new System.Windows.Forms.Button();
            this.info_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // info_gb
            // 
            this.info_gb.Controls.Add(this.expiryDate_tb);
            this.info_gb.Controls.Add(this.description_lbl);
            this.info_gb.Controls.Add(this.description_tb);
            this.info_gb.Controls.Add(this.name_lbl1);
            this.info_gb.Controls.Add(this.name_tb1);
            this.info_gb.Controls.Add(this.date_tb1);
            this.info_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_gb.Location = new System.Drawing.Point(41, 24);
            this.info_gb.Name = "info_gb";
            this.info_gb.Size = new System.Drawing.Size(367, 320);
            this.info_gb.TabIndex = 0;
            this.info_gb.TabStop = false;
            this.info_gb.Text = "Info";
            // 
            // expiryDate_tb
            // 
            this.expiryDate_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDate_tb.Location = new System.Drawing.Point(12, 242);
            this.expiryDate_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expiryDate_tb.Name = "expiryDate_tb";
            this.expiryDate_tb.ReadOnly = true;
            this.expiryDate_tb.Size = new System.Drawing.Size(233, 30);
            this.expiryDate_tb.TabIndex = 21;
            // 
            // description_lbl
            // 
            this.description_lbl.AutoSize = true;
            this.description_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lbl.Location = new System.Drawing.Point(7, 124);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(127, 25);
            this.description_lbl.TabIndex = 20;
            this.description_lbl.Text = "Description:";
            // 
            // description_tb
            // 
            this.description_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.Location = new System.Drawing.Point(13, 151);
            this.description_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.ReadOnly = true;
            this.description_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_tb.Size = new System.Drawing.Size(233, 41);
            this.description_tb.TabIndex = 19;
            // 
            // name_lbl1
            // 
            this.name_lbl1.AutoSize = true;
            this.name_lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl1.Location = new System.Drawing.Point(7, 56);
            this.name_lbl1.Name = "name_lbl1";
            this.name_lbl1.Size = new System.Drawing.Size(75, 25);
            this.name_lbl1.TabIndex = 17;
            this.name_lbl1.Text = "Name:";
            // 
            // name_tb1
            // 
            this.name_tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tb1.Location = new System.Drawing.Point(13, 83);
            this.name_tb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_tb1.Name = "name_tb1";
            this.name_tb1.ReadOnly = true;
            this.name_tb1.Size = new System.Drawing.Size(233, 30);
            this.name_tb1.TabIndex = 16;
            // 
            // date_tb1
            // 
            this.date_tb1.AutoSize = true;
            this.date_tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_tb1.Location = new System.Drawing.Point(7, 215);
            this.date_tb1.Name = "date_tb1";
            this.date_tb1.Size = new System.Drawing.Size(331, 25);
            this.date_tb1.TabIndex = 15;
            this.date_tb1.Text = "ExpiryDate: Format(dd/MM/yyyy)";
            // 
            // close_butt1
            // 
            this.close_butt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.close_butt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_butt1.ForeColor = System.Drawing.Color.White;
            this.close_butt1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_butt1.Location = new System.Drawing.Point(12, 337);
            this.close_butt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close_butt1.Name = "close_butt1";
            this.close_butt1.Size = new System.Drawing.Size(253, 64);
            this.close_butt1.TabIndex = 8;
            this.close_butt1.Text = "Schliessen";
            this.close_butt1.UseVisualStyleBackColor = false;
            this.close_butt1.Click += new System.EventHandler(this.close_butt1_Click);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(201, 366);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(11, 16);
            this.id_lbl.TabIndex = 9;
            this.id_lbl.Text = "-";
            // 
            // delete_butt1
            // 
            this.delete_butt1.BackgroundImage = global::M320_ToDoApp_Crud.Properties.Resources.delete_icon;
            this.delete_butt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_butt1.Location = new System.Drawing.Point(271, 337);
            this.delete_butt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_butt1.Name = "delete_butt1";
            this.delete_butt1.Size = new System.Drawing.Size(118, 64);
            this.delete_butt1.TabIndex = 10;
            this.delete_butt1.UseVisualStyleBackColor = true;
            this.delete_butt1.Click += new System.EventHandler(this.delete_butt1_Click);
            // 
            // ViewSingleToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 421);
            this.Controls.Add(this.delete_butt1);
            this.Controls.Add(this.close_butt1);
            this.Controls.Add(this.info_gb);
            this.Controls.Add(this.id_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewSingleToDo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSingleToDo";
            this.Load += new System.EventHandler(this.ViewSingleToDo_Load);
            this.info_gb.ResumeLayout(false);
            this.info_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox info_gb;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.Label name_lbl1;
        private System.Windows.Forms.Label date_tb1;
        public System.Windows.Forms.TextBox description_tb;
        public System.Windows.Forms.TextBox name_tb1;
        public System.Windows.Forms.TextBox expiryDate_tb;
        private System.Windows.Forms.Button close_butt1;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Button delete_butt1;
    }
}