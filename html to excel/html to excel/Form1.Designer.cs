namespace html_to_excel
{
    partial class Form1
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
            this.importButon = new System.Windows.Forms.Button();
            this.exportBotun = new System.Windows.Forms.Button();
            this.excelname = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.indeces = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // importButon
            // 
            this.importButon.Location = new System.Drawing.Point(12, 12);
            this.importButon.Name = "importButon";
            this.importButon.Size = new System.Drawing.Size(109, 36);
            this.importButon.TabIndex = 0;
            this.importButon.Text = "import txt";
            this.importButon.UseVisualStyleBackColor = true;
            this.importButon.Click += new System.EventHandler(this.importButon_Click);
            // 
            // exportBotun
            // 
            this.exportBotun.Location = new System.Drawing.Point(12, 54);
            this.exportBotun.Name = "exportBotun";
            this.exportBotun.Size = new System.Drawing.Size(109, 36);
            this.exportBotun.TabIndex = 1;
            this.exportBotun.Text = "export excel";
            this.exportBotun.UseVisualStyleBackColor = true;
            // 
            // excelname
            // 
            this.excelname.Location = new System.Drawing.Point(127, 61);
            this.excelname.Name = "excelname";
            this.excelname.Size = new System.Drawing.Size(151, 22);
            this.excelname.TabIndex = 3;
            this.excelname.Text = "output1";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(127, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "name your excel";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // indeces
            // 
            this.indeces.Location = new System.Drawing.Point(7, 219);
            this.indeces.Name = "indeces";
            this.indeces.Size = new System.Drawing.Size(271, 22);
            this.indeces.TabIndex = 5;
            this.indeces.Text = "1,16,69,83,101,119,137,155,173,191,209,227,246,";
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(23, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "what character do your cells start at ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.indeces);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.excelname);
            this.Controls.Add(this.exportBotun);
            this.Controls.Add(this.importButon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importButon;
        private System.Windows.Forms.Button exportBotun;
        private System.Windows.Forms.TextBox excelname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox indeces;
        private System.Windows.Forms.TextBox label2;
    }
}

