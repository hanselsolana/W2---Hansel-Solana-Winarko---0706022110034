namespace W2___Hansel_Solana_Winarko___0706022110034
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
            this.lbl_inputdata = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btn_proses = new System.Windows.Forms.Button();
            this.lbl_empty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_inputdata
            // 
            this.lbl_inputdata.AutoSize = true;
            this.lbl_inputdata.Location = new System.Drawing.Point(32, 39);
            this.lbl_inputdata.Name = "lbl_inputdata";
            this.lbl_inputdata.Size = new System.Drawing.Size(86, 20);
            this.lbl_inputdata.TabIndex = 1;
            this.lbl_inputdata.Text = "Input data:";
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(36, 77);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(208, 26);
            this.txtbox.TabIndex = 2;
            this.txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_proses
            // 
            this.btn_proses.Location = new System.Drawing.Point(36, 139);
            this.btn_proses.Name = "btn_proses";
            this.btn_proses.Size = new System.Drawing.Size(128, 31);
            this.btn_proses.TabIndex = 3;
            this.btn_proses.Text = "Proses";
            this.btn_proses.UseVisualStyleBackColor = true;
            this.btn_proses.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_empty
            // 
            this.lbl_empty.AutoSize = true;
            this.lbl_empty.Location = new System.Drawing.Point(32, 204);
            this.lbl_empty.Name = "lbl_empty";
            this.lbl_empty.Size = new System.Drawing.Size(71, 20);
            this.lbl_empty.TabIndex = 4;
            this.lbl_empty.Text = "[EMPTY]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_empty);
            this.Controls.Add(this.btn_proses);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.lbl_inputdata);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_inputdata;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btn_proses;
        private System.Windows.Forms.Label lbl_empty;
    }
}

