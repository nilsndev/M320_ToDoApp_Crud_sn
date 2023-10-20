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
            this.output_dgv = new System.Windows.Forms.DataGridView();
            this.delete_butt1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.update_butt1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.output_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // output_dgv
            // 
            this.output_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output_dgv.Location = new System.Drawing.Point(157, 214);
            this.output_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output_dgv.Name = "output_dgv";
            this.output_dgv.RowHeadersWidth = 51;
            this.output_dgv.RowTemplate.Height = 24;
            this.output_dgv.Size = new System.Drawing.Size(519, 201);
            this.output_dgv.TabIndex = 0;
            // 
            // delete_butt1
            // 
            this.delete_butt1.Location = new System.Drawing.Point(228, 39);
            this.delete_butt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_butt1.Name = "delete_butt1";
            this.delete_butt1.Size = new System.Drawing.Size(177, 100);
            this.delete_butt1.TabIndex = 1;
            this.delete_butt1.Text = "Delete ToDO";
            this.delete_butt1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add ToDO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_butt1
            // 
            this.update_butt1.Location = new System.Drawing.Point(591, 39);
            this.update_butt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_butt1.Name = "update_butt1";
            this.update_butt1.Size = new System.Drawing.Size(177, 100);
            this.update_butt1.TabIndex = 2;
            this.update_butt1.Text = "Update ToDO";
            this.update_butt1.UseVisualStyleBackColor = true;
            this.update_butt1.Click += new System.EventHandler(this.update_butt1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 100);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update_butt1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_butt1);
            this.Controls.Add(this.output_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button2;
    }
}