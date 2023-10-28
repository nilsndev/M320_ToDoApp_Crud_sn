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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.output_dgv = new System.Windows.Forms.DataGridView();
            this.delete_butt1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.update_butt1 = new System.Windows.Forms.Button();
            this.clear_butt = new System.Windows.Forms.Button();
            this.loadDataFromFile_butt = new System.Windows.Forms.Button();
            this.saveDatainFile_butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.output_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // output_dgv
            // 
            this.output_dgv.AllowUserToAddRows = false;
            this.output_dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.output_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.output_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.output_dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.output_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.output_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.output_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.output_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.output_dgv.EnableHeadersVisualStyles = false;
            this.output_dgv.GridColor = System.Drawing.Color.White;
            this.output_dgv.Location = new System.Drawing.Point(17, 138);
            this.output_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.output_dgv.Name = "output_dgv";
            this.output_dgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.output_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.output_dgv.RowHeadersWidth = 51;
            this.output_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.output_dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.output_dgv.RowTemplate.Height = 24;
            this.output_dgv.Size = new System.Drawing.Size(389, 163);
            this.output_dgv.TabIndex = 0;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.update_butt1.Click += new System.EventHandler(this.update_butt1_Click);
            // 
            // clear_butt
            // 
            this.clear_butt.Location = new System.Drawing.Point(309, 32);
            this.clear_butt.Name = "clear_butt";
            this.clear_butt.Size = new System.Drawing.Size(129, 81);
            this.clear_butt.TabIndex = 3;
            this.clear_butt.Text = "Clear";
            this.clear_butt.UseVisualStyleBackColor = true;
            this.clear_butt.Click += new System.EventHandler(this.clear_butt_Click);
            // 
            // loadDataFromFile_butt
            // 
            this.loadDataFromFile_butt.Location = new System.Drawing.Point(443, 138);
            this.loadDataFromFile_butt.Name = "loadDataFromFile_butt";
            this.loadDataFromFile_butt.Size = new System.Drawing.Size(129, 81);
            this.loadDataFromFile_butt.TabIndex = 4;
            this.loadDataFromFile_butt.Text = "LoadDataFromFile";
            this.loadDataFromFile_butt.UseVisualStyleBackColor = true;
            this.loadDataFromFile_butt.Click += new System.EventHandler(this.loadDataFromFile_butt_Click);
            // 
            // saveDatainFile_butt
            // 
            this.saveDatainFile_butt.Location = new System.Drawing.Point(443, 236);
            this.saveDatainFile_butt.Name = "saveDatainFile_butt";
            this.saveDatainFile_butt.Size = new System.Drawing.Size(129, 81);
            this.saveDatainFile_butt.TabIndex = 5;
            this.saveDatainFile_butt.Text = "SaveDatainFile";
            this.saveDatainFile_butt.UseVisualStyleBackColor = true;
            this.saveDatainFile_butt.Click += new System.EventHandler(this.saveDatainFile_butt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.saveDatainFile_butt);
            this.Controls.Add(this.loadDataFromFile_butt);
            this.Controls.Add(this.clear_butt);
            this.Controls.Add(this.update_butt1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_butt1);
            this.Controls.Add(this.output_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.output_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView output_dgv;
        private System.Windows.Forms.Button delete_butt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button update_butt1;
        private System.Windows.Forms.Button clear_butt;
        private System.Windows.Forms.Button loadDataFromFile_butt;
        private System.Windows.Forms.Button saveDatainFile_butt;
    }
}