namespace AsyncAwaitForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textDemano = new System.Windows.Forms.TextBox();
            this.Btclica = new System.Windows.Forms.Button();
            this.textFinal = new System.Windows.Forms.TextBox();
            this.textInicial = new System.Windows.Forms.TextBox();
            this.btMentres = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Demano: ";
            // 
            // textDemano
            // 
            this.textDemano.Location = new System.Drawing.Point(105, 48);
            this.textDemano.Name = "textDemano";
            this.textDemano.Size = new System.Drawing.Size(131, 20);
            this.textDemano.TabIndex = 1;
            this.textDemano.TextChanged += new System.EventHandler(this.textDemano_TextChanged);
            // 
            // Btclica
            // 
            this.Btclica.Location = new System.Drawing.Point(317, 48);
            this.Btclica.Name = "Btclica";
            this.Btclica.Size = new System.Drawing.Size(75, 23);
            this.Btclica.TabIndex = 2;
            this.Btclica.Text = "Clica";
            this.Btclica.UseVisualStyleBackColor = true;
            this.Btclica.Click += new System.EventHandler(this.Btclica_Click);
            // 
            // textFinal
            // 
            this.textFinal.Location = new System.Drawing.Point(23, 160);
            this.textFinal.Name = "textFinal";
            this.textFinal.Size = new System.Drawing.Size(257, 20);
            this.textFinal.TabIndex = 3;
            // 
            // textInicial
            // 
            this.textInicial.Location = new System.Drawing.Point(105, 120);
            this.textInicial.Name = "textInicial";
            this.textInicial.Size = new System.Drawing.Size(131, 20);
            this.textInicial.TabIndex = 4;
            // 
            // btMentres
            // 
            this.btMentres.Location = new System.Drawing.Point(317, 104);
            this.btMentres.Name = "btMentres";
            this.btMentres.Size = new System.Drawing.Size(75, 23);
            this.btMentres.TabIndex = 5;
            this.btMentres.Text = "Conversa";
            this.btMentres.UseVisualStyleBackColor = true;
            this.btMentres.Click += new System.EventHandler(this.btMentres_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(317, 151);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btMentres);
            this.Controls.Add(this.textInicial);
            this.Controls.Add(this.textFinal);
            this.Controls.Add(this.Btclica);
            this.Controls.Add(this.textDemano);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDemanar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDemano;
        private System.Windows.Forms.Button Btclica;
        private System.Windows.Forms.TextBox textFinal;
        private System.Windows.Forms.TextBox textInicial;
        private System.Windows.Forms.Button btMentres;
        private System.Windows.Forms.ListBox listBox1;
    }
}

