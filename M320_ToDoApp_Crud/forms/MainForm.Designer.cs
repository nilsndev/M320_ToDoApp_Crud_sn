namespace M320_ToDoApp_Crud.forms
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete_butt1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.update_butt1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 174);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // delete_butt1
            // 
            this.delete_butt1.Location = new System.Drawing.Point(171, 32);
            this.delete_butt1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete_butt1.Name = "delete_butt1";
            this.delete_butt1.Size = new System.Drawing.Size(133, 81);
            this.delete_butt1.TabIndex = 1;
            this.delete_butt1.Text = "Delete ToDO";
            this.delete_butt1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add ToDO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // update_butt1
            // 
            this.update_butt1.Location = new System.Drawing.Point(443, 32);
            this.update_butt1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update_butt1.Name = "update_butt1";
            this.update_butt1.Size = new System.Drawing.Size(133, 81);
            this.update_butt1.TabIndex = 2;
            this.update_butt1.Text = "Update ToDO";
            this.update_butt1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 81);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update_butt1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_butt1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_butt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button update_butt1;
        private System.Windows.Forms.Button button2;
    }
}