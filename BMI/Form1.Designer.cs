namespace BMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_boy = new System.Windows.Forms.Label();
            this.lbl_kilo = new System.Windows.Forms.Label();
            this.lbl_dt = new System.Windows.Forms.Label();
            this.lbl_cins = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_cins = new System.Windows.Forms.ComboBox();
            this.txt_yil = new System.Windows.Forms.TextBox();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.txt_boy = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_vki = new System.Windows.Forms.Label();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vKEHesaplanmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vKEHesabıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idealKiloHesabıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_boy
            // 
            resources.ApplyResources(this.lbl_boy, "lbl_boy");
            this.lbl_boy.Name = "lbl_boy";
            this.lbl_boy.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_kilo
            // 
            resources.ApplyResources(this.lbl_kilo, "lbl_kilo");
            this.lbl_kilo.Name = "lbl_kilo";
            // 
            // lbl_dt
            // 
            resources.ApplyResources(this.lbl_dt, "lbl_dt");
            this.lbl_dt.Name = "lbl_dt";
            // 
            // lbl_cins
            // 
            resources.ApplyResources(this.lbl_cins, "lbl_cins");
            this.lbl_cins.Name = "lbl_cins";
            this.lbl_cins.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmb_cins);
            this.groupBox1.Controls.Add(this.txt_yil);
            this.groupBox1.Controls.Add(this.txt_kilo);
            this.groupBox1.Controls.Add(this.lbl_boy);
            this.groupBox1.Controls.Add(this.lbl_cins);
            this.groupBox1.Controls.Add(this.lbl_kilo);
            this.groupBox1.Controls.Add(this.lbl_dt);
            this.groupBox1.Controls.Add(this.txt_boy);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_cins
            // 
            resources.ApplyResources(this.cmb_cins, "cmb_cins");
            this.cmb_cins.FormattingEnabled = true;
            this.cmb_cins.Items.AddRange(new object[] {
            resources.GetString("cmb_cins.Items"),
            resources.GetString("cmb_cins.Items1")});
            this.cmb_cins.Name = "cmb_cins";
            // 
            // txt_yil
            // 
            resources.ApplyResources(this.txt_yil, "txt_yil");
            this.txt_yil.Name = "txt_yil";
            this.txt_yil.TextChanged += new System.EventHandler(this.txt_yil_TextChanged);
            // 
            // txt_kilo
            // 
            resources.ApplyResources(this.txt_kilo, "txt_kilo");
            this.txt_kilo.Name = "txt_kilo";
            // 
            // txt_boy
            // 
            resources.ApplyResources(this.txt_boy, "txt_boy");
            this.txt_boy.Name = "txt_boy";
            this.txt_boy.TextChanged += new System.EventHandler(this.txt_boy_TextChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_vki);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_vki
            // 
            resources.ApplyResources(this.lbl_vki, "lbl_vki");
            this.lbl_vki.Name = "lbl_vki";
            // 
            // dosyaToolStripMenuItem
            // 
            resources.ApplyResources(this.dosyaToolStripMenuItem, "dosyaToolStripMenuItem");
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            // 
            // resetToolStripMenuItem
            // 
            resources.ApplyResources(this.resetToolStripMenuItem, "resetToolStripMenuItem");
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            resources.ApplyResources(this.çıkışToolStripMenuItem, "çıkışToolStripMenuItem");
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            resources.ApplyResources(this.hakkındaToolStripMenuItem, "hakkındaToolStripMenuItem");
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vKEHesaplanmasıToolStripMenuItem,
            this.hakkındaToolStripMenuItem1});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            // 
            // vKEHesaplanmasıToolStripMenuItem
            // 
            resources.ApplyResources(this.vKEHesaplanmasıToolStripMenuItem, "vKEHesaplanmasıToolStripMenuItem");
            this.vKEHesaplanmasıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vKEHesabıToolStripMenuItem,
            this.idealKiloHesabıToolStripMenuItem});
            this.vKEHesaplanmasıToolStripMenuItem.Name = "vKEHesaplanmasıToolStripMenuItem";
            // 
            // vKEHesabıToolStripMenuItem
            // 
            resources.ApplyResources(this.vKEHesabıToolStripMenuItem, "vKEHesabıToolStripMenuItem");
            this.vKEHesabıToolStripMenuItem.Name = "vKEHesabıToolStripMenuItem";
            this.vKEHesabıToolStripMenuItem.Click += new System.EventHandler(this.vKEHesabıToolStripMenuItem_Click);
            // 
            // idealKiloHesabıToolStripMenuItem
            // 
            resources.ApplyResources(this.idealKiloHesabıToolStripMenuItem, "idealKiloHesabıToolStripMenuItem");
            this.idealKiloHesabıToolStripMenuItem.Name = "idealKiloHesabıToolStripMenuItem";
            this.idealKiloHesabıToolStripMenuItem.Click += new System.EventHandler(this.idealKiloHesabıToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem1
            // 
            resources.ApplyResources(this.hakkındaToolStripMenuItem1, "hakkındaToolStripMenuItem1");
            this.hakkındaToolStripMenuItem1.Name = "hakkındaToolStripMenuItem1";
            this.hakkındaToolStripMenuItem1.Click += new System.EventHandler(this.hakkındaToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::BMI.Properties.Resources.rsz_turkey_flag_icon2;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::BMI.Properties.Resources.rsz_ingiltere_bayrak_ikon;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_boy;
        private System.Windows.Forms.Label lbl_kilo;
        private System.Windows.Forms.Label lbl_dt;
        private System.Windows.Forms.Label lbl_cins;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_yil;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.TextBox txt_boy;
        private System.Windows.Forms.ComboBox cmb_cins;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_vki;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem vKEHesaplanmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vKEHesabıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idealKiloHesabıToolStripMenuItem;
    }
}

