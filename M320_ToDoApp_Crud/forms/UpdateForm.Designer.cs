namespace M320_ToDoApp_Crud.forms
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.update_butt1 = new System.Windows.Forms.Button();
            this.data_pan1 = new System.Windows.Forms.Panel();
            this.description_lbl = new System.Windows.Forms.Label();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.name_lbl1 = new System.Windows.Forms.Label();
            this.select_item_lbl1 = new System.Windows.Forms.Label();
            this.name_tb1 = new System.Windows.Forms.TextBox();
            this.items_cb1 = new System.Windows.Forms.ComboBox();
            this.date_tb1 = new System.Windows.Forms.Label();
            this.header_lbl = new System.Windows.Forms.Label();
            this.data_pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // update_butt1
            // 
            this.update_butt1.BackColor = System.Drawing.Color.Blue;
            this.update_butt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_butt1.ForeColor = System.Drawing.Color.White;
            this.update_butt1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_butt1.Location = new System.Drawing.Point(82, 505);
            this.update_butt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_butt1.Name = "update_butt1";
            this.update_butt1.Size = new System.Drawing.Size(253, 64);
            this.update_butt1.TabIndex = 7;
            this.update_butt1.Text = "Update ";
            this.update_butt1.UseVisualStyleBackColor = false;
            this.update_butt1.Click += new System.EventHandler(this.update_butt1_Click);
            // 
            // data_pan1
            // 
            this.data_pan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_pan1.Controls.Add(this.description_lbl);
            this.data_pan1.Controls.Add(this.description_tb);
            this.data_pan1.Controls.Add(this.dateTimePicker1);
            this.data_pan1.Controls.Add(this.name_lbl1);
            this.data_pan1.Controls.Add(this.select_item_lbl1);
            this.data_pan1.Controls.Add(this.name_tb1);
            this.data_pan1.Controls.Add(this.items_cb1);
            this.data_pan1.Controls.Add(this.date_tb1);
            this.data_pan1.Location = new System.Drawing.Point(27, 106);
            this.data_pan1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_pan1.Name = "data_pan1";
            this.data_pan1.Size = new System.Drawing.Size(409, 371);
            this.data_pan1.TabIndex = 6;
            this.data_pan1.Paint += new System.Windows.Forms.PaintEventHandler(this.data_pan1_Paint);
            // 
            // description_lbl
            // 
            this.description_lbl.AutoSize = true;
            this.description_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lbl.Location = new System.Drawing.Point(37, 190);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(127, 25);
            this.description_lbl.TabIndex = 14;
            this.description_lbl.Text = "Description:";
            // 
            // description_tb
            // 
            this.description_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.Location = new System.Drawing.Point(43, 217);
            this.description_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.description_tb.Size = new System.Drawing.Size(233, 37);
            this.description_tb.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 307);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 24);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 31, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // name_lbl1
            // 
            this.name_lbl1.AutoSize = true;
            this.name_lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl1.Location = new System.Drawing.Point(37, 122);
            this.name_lbl1.Name = "name_lbl1";
            this.name_lbl1.Size = new System.Drawing.Size(75, 25);
            this.name_lbl1.TabIndex = 5;
            this.name_lbl1.Text = "Name:";
            // 
            // select_item_lbl1
            // 
            this.select_item_lbl1.AutoSize = true;
            this.select_item_lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_item_lbl1.Location = new System.Drawing.Point(37, 46);
            this.select_item_lbl1.Name = "select_item_lbl1";
            this.select_item_lbl1.Size = new System.Drawing.Size(127, 25);
            this.select_item_lbl1.TabIndex = 5;
            this.select_item_lbl1.Text = "Select One:";
            // 
            // name_tb1
            // 
            this.name_tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tb1.Location = new System.Drawing.Point(43, 149);
            this.name_tb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_tb1.Name = "name_tb1";
            this.name_tb1.Size = new System.Drawing.Size(233, 30);
            this.name_tb1.TabIndex = 4;
            // 
            // items_cb1
            // 
            this.items_cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.items_cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.items_cb1.FormattingEnabled = true;
            this.items_cb1.Location = new System.Drawing.Point(43, 73);
            this.items_cb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.items_cb1.Name = "items_cb1";
            this.items_cb1.Size = new System.Drawing.Size(233, 33);
            this.items_cb1.TabIndex = 4;
            this.items_cb1.SelectedValueChanged += new System.EventHandler(this.items_cb1_SelectedValueChanged);
            // 
            // date_tb1
            // 
            this.date_tb1.AutoSize = true;
            this.date_tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_tb1.Location = new System.Drawing.Point(37, 269);
            this.date_tb1.Name = "date_tb1";
            this.date_tb1.Size = new System.Drawing.Size(331, 25);
            this.date_tb1.TabIndex = 3;
            this.date_tb1.Text = "ExpiryDate: Format(dd/MM/yyyy)";
            // 
            // header_lbl
            // 
            this.header_lbl.AutoSize = true;
            this.header_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_lbl.Location = new System.Drawing.Point(61, 34);
            this.header_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header_lbl.Name = "header_lbl";
            this.header_lbl.Size = new System.Drawing.Size(312, 54);
            this.header_lbl.TabIndex = 8;
            this.header_lbl.Text = "Update ToDo";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 580);
            this.Controls.Add(this.header_lbl);
            this.Controls.Add(this.update_butt1);
            this.Controls.Add(this.data_pan1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.data_pan1.ResumeLayout(false);
            this.data_pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_butt1;
        private System.Windows.Forms.Panel data_pan1;
        private System.Windows.Forms.Label name_lbl1;
        private System.Windows.Forms.TextBox name_tb1;
        private System.Windows.Forms.Label date_tb1;
        private System.Windows.Forms.Label select_item_lbl1;
        private System.Windows.Forms.ComboBox items_cb1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label header_lbl;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.TextBox description_tb;
    }
}