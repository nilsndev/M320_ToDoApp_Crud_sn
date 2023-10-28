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
            this.update_butt1 = new System.Windows.Forms.Button();
            this.data_pan1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.name_lbl1 = new System.Windows.Forms.Label();
            this.name_tb1 = new System.Windows.Forms.TextBox();
            this.date_tb1 = new System.Windows.Forms.Label();
            this.select_item_lbl1 = new System.Windows.Forms.Label();
            this.items_cb1 = new System.Windows.Forms.ComboBox();
            this.data_pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // update_butt1
            // 
            this.update_butt1.Location = new System.Drawing.Point(128, 369);
            this.update_butt1.Name = "update_butt1";
            this.update_butt1.Size = new System.Drawing.Size(168, 75);
            this.update_butt1.TabIndex = 7;
            this.update_butt1.Text = "Update ";
            this.update_butt1.UseVisualStyleBackColor = true;
            this.update_butt1.Click += new System.EventHandler(this.update_butt1_Click);
            // 
            // data_pan1
            // 
            this.data_pan1.Controls.Add(this.dateTimePicker1);
            this.data_pan1.Controls.Add(this.name_lbl1);
            this.data_pan1.Controls.Add(this.name_tb1);
            this.data_pan1.Controls.Add(this.date_tb1);
            this.data_pan1.Location = new System.Drawing.Point(69, 108);
            this.data_pan1.Name = "data_pan1";
            this.data_pan1.Size = new System.Drawing.Size(303, 232);
            this.data_pan1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // name_lbl1
            // 
            this.name_lbl1.AutoSize = true;
            this.name_lbl1.Location = new System.Drawing.Point(39, 55);
            this.name_lbl1.Name = "name_lbl1";
            this.name_lbl1.Size = new System.Drawing.Size(47, 16);
            this.name_lbl1.TabIndex = 5;
            this.name_lbl1.Text = "Name:";
            // 
            // name_tb1
            // 
            this.name_tb1.Location = new System.Drawing.Point(42, 74);
            this.name_tb1.Name = "name_tb1";
            this.name_tb1.Size = new System.Drawing.Size(100, 22);
            this.name_tb1.TabIndex = 4;
            // 
            // date_tb1
            // 
            this.date_tb1.AutoSize = true;
            this.date_tb1.Location = new System.Drawing.Point(39, 130);
            this.date_tb1.Name = "date_tb1";
            this.date_tb1.Size = new System.Drawing.Size(203, 16);
            this.date_tb1.TabIndex = 3;
            this.date_tb1.Text = "ExpiryDate: Format(dd/MM/yyyy)";
            // 
            // select_item_lbl1
            // 
            this.select_item_lbl1.AutoSize = true;
            this.select_item_lbl1.Location = new System.Drawing.Point(66, 33);
            this.select_item_lbl1.Name = "select_item_lbl1";
            this.select_item_lbl1.Size = new System.Drawing.Size(105, 16);
            this.select_item_lbl1.TabIndex = 5;
            this.select_item_lbl1.Text = "Select_Item_lbl1";
            // 
            // items_cb1
            // 
            this.items_cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.items_cb1.FormattingEnabled = true;
            this.items_cb1.Location = new System.Drawing.Point(69, 65);
            this.items_cb1.Name = "items_cb1";
            this.items_cb1.Size = new System.Drawing.Size(152, 24);
            this.items_cb1.TabIndex = 4;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 517);
            this.Controls.Add(this.update_butt1);
            this.Controls.Add(this.data_pan1);
            this.Controls.Add(this.select_item_lbl1);
            this.Controls.Add(this.items_cb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.ShowIcon = false;
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
    }
}