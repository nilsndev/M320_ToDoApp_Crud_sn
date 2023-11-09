namespace M320_ToDoApp_Crud.forms
{
    partial class AddForm
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
            this.add_butt = new System.Windows.Forms.Button();
            this.info_gb = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.description_lbl = new System.Windows.Forms.Label();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.name_lbl1 = new System.Windows.Forms.Label();
            this.name_tb1 = new System.Windows.Forms.TextBox();
            this.date_tb1 = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.info_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_butt
            // 
            this.add_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.add_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_butt.ForeColor = System.Drawing.Color.White;
            this.add_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_butt.Location = new System.Drawing.Point(53, 364);
            this.add_butt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_butt.Name = "add_butt";
            this.add_butt.Size = new System.Drawing.Size(253, 64);
            this.add_butt.TabIndex = 12;
            this.add_butt.Text = "Hinzufügen";
            this.add_butt.UseVisualStyleBackColor = false;
            this.add_butt.Click += new System.EventHandler(this.add_butt_Click);
            // 
            // info_gb
            // 
            this.info_gb.Controls.Add(this.dateTimePicker1);
            this.info_gb.Controls.Add(this.description_lbl);
            this.info_gb.Controls.Add(this.description_tb);
            this.info_gb.Controls.Add(this.name_lbl1);
            this.info_gb.Controls.Add(this.name_tb1);
            this.info_gb.Controls.Add(this.date_tb1);
            this.info_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_gb.Location = new System.Drawing.Point(41, 13);
            this.info_gb.Name = "info_gb";
            this.info_gb.Size = new System.Drawing.Size(367, 320);
            this.info_gb.TabIndex = 11;
            this.info_gb.TabStop = false;
            this.info_gb.Text = "Info";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 264);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 24);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 31, 0, 0, 0, 0);
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
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(233, 30);
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
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(201, 355);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(11, 16);
            this.id_lbl.TabIndex = 13;
            this.id_lbl.Text = "-";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.add_butt);
            this.Controls.Add(this.info_gb);
            this.Controls.Add(this.id_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.info_gb.ResumeLayout(false);
            this.info_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_butt;
        private System.Windows.Forms.GroupBox info_gb;
        private System.Windows.Forms.Label description_lbl;
        public System.Windows.Forms.TextBox description_tb;
        private System.Windows.Forms.Label name_lbl1;
        public System.Windows.Forms.TextBox name_tb1;
        private System.Windows.Forms.Label date_tb1;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}