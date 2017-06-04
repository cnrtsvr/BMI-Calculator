using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Threading;


namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class RuntimeLocalizer
        {
            public static void ChangeCulture(Form frm, string cultureCode)
            {
                CultureInfo culture = CultureInfo.GetCultureInfo(cultureCode);

                Thread.CurrentThread.CurrentUICulture = culture;

                ComponentResourceManager resources = new ComponentResourceManager(frm.GetType());

                ApplyResourceToControl(resources, frm, culture);
                resources.ApplyResources(frm, "$this", culture);
            }

            private static void ApplyResourceToControl(ComponentResourceManager res, Control control, CultureInfo lang)
            {
                if (control.GetType() == typeof(MenuStrip))  // See if this is a menuStrip
                {
                    MenuStrip strip = (MenuStrip)control;

                    ApplyResourceToToolStripItemCollection(strip.Items, res, lang);
                }

                foreach (Control c in control.Controls) // Apply to all sub-controls
                {
                    ApplyResourceToControl(res, c, lang);
                    res.ApplyResources(c, c.Name, lang);
                }

                // Apply to self
                res.ApplyResources(control, control.Name, lang);
            }

            private static void ApplyResourceToToolStripItemCollection(ToolStripItemCollection col, ComponentResourceManager res, CultureInfo lang)
            {
                for (int i = 0; i < col.Count; i++)     // Apply to all sub items
                {
                    ToolStripItem item = (ToolStripMenuItem)col[i];

                    if (item.GetType() == typeof(ToolStripMenuItem))
                    {
                        ToolStripMenuItem menuitem = (ToolStripMenuItem)item;
                        ApplyResourceToToolStripItemCollection(menuitem.DropDownItems, res, lang);
                    }

                    res.ApplyResources(item, item.Name, lang);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_yil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_boy_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas;
            double boy;
            int kilo;
            double vki;
            double ikilo;

            if (txt_boy.Text == "")
            {
                if (lbl_cins.Text == "Cinsiyet    :")
                {
                    MessageBox.Show("Boy Değerini Giriniz !", "Uyarı !");
                }
                else if (lbl_cins.Text == "Gender    :")
                {
                    MessageBox.Show("Please Enter Your Height Value !", "Warning !");
                }
                txt_boy.Focus();
            }
            else if (txt_kilo.Text == "")
            {
                if (lbl_cins.Text == "Cinsiyet    :")
                {
                    MessageBox.Show("Kilo Değerini Giriniz !", "Uyarı !");
                }
                else if (lbl_cins.Text == "Gender    :")
                {
                    MessageBox.Show("Please Enter Your Weight Value !", "Warning !");
                }
                txt_kilo.Focus();
            }
            else if (txt_yil.Text == "Yıl" || txt_yil.Text == "Year")
            {
                if (lbl_cins.Text == "Cinsiyet    :")
                {
                    MessageBox.Show("Doğum Yılını Giriniz !", "Uyarı !");
                }
                else if (lbl_cins.Text == "Gender    :")
                {
                    MessageBox.Show("Please Enter Your Birth Year !", "Warning !");
                }
                txt_yil.Focus();
            }
            else if (Int32.Parse(txt_yil.Text) > 1998)
            {
                if (lbl_cins.Text == "Cinsiyet    :")
                {
                    MessageBox.Show("Program 19 yaş ve üstü için yazılmıştır !", "Uyarı !");
                }
                else if (lbl_cins.Text == "Gender    :")
                {
                    MessageBox.Show("This program is written for over 19 years and older !", "Warning !");
                }                
                txt_yil.Focus();
            }
            else if (cmb_cins.Text == "Seçiniz :" || cmb_cins.Text == "Select :")
            {
                if (lbl_cins.Text == "Cinsiyet    :")
                {
                    MessageBox.Show("Cinsiyetinizi Seçiniz !", "Uyarı !");
                }
                else if (lbl_cins.Text == "Gender    :")
                {
                    MessageBox.Show("Please Select Your Gender !", "Warning !");
                }
                cmb_cins.Focus();
            }
            else
            {
                kilo = Int32.Parse(txt_kilo.Text); 
                boy = Int32.Parse(txt_boy.Text);
                boy = boy / 100;
                vki = kilo / (boy * boy);
                vki = Math.Round(vki, 3);
                yas = 2017 - Int32.Parse(txt_yil.Text);
                label3.Text = vki.ToString();
                if (yas >= 19 && yas <= 24)
                {
                    ikilo = 24 * (boy * boy);
                    ikilo = Math.Round(ikilo, 3);
                    label5.Text = ikilo.ToString() + " kg";
                }
                else if (yas >= 25 && yas <= 34)
                {
                    ikilo = 25 * (boy * boy);
                    ikilo = Math.Round(ikilo, 3);
                    label5.Text = ikilo.ToString() + " kg";
                }
                else if (yas >= 35 && yas <= 44)
                {
                    ikilo = 26 * (boy * boy);
                    ikilo = Math.Round(ikilo, 3);
                    label5.Text = ikilo.ToString() + " kg";
                }
                else if (yas >= 45 && yas <= 54)
                {
                    ikilo = 27 * (boy * boy);
                    ikilo = Math.Round(ikilo, 3);
                    label5.Text = ikilo.ToString() + " kg";
                }
                else if (yas >= 55 && yas <= 65)
                {
                    ikilo = 28 * (boy * boy);
                    ikilo = Math.Round(ikilo, 3);
                    label5.Text = ikilo.ToString() + " kg";
                }
                else
                {
                    ikilo = 29 * (boy * boy);
                    ikilo = Math.Round(ikilo, 3);
                    label5.Text = ikilo.ToString() + " kg";
                }
                switch (cmb_cins.Text)
                {
                    case "Male":
                    case "Erkek":
                        if (lbl_cins.Text == "Gender    :")
                        {
                            if (vki < 20.7)
                            {
                                textBox2.Text = "Thinness. Small BMIs are also a risk.";
                            }
                            if (vki >= 20.7 && vki <= 26.4)
                            {
                                textBox2.Text = "Your BMI is normal. There is no risk.";
                            }
                            if (vki >= 26.5 && vki <= 27.8)
                            {
                                textBox2.Text = "Overweight. There is a small risk.";
                            }
                            if (vki >= 27.9 && vki <= 31.1)
                            {
                                textBox2.Text = "Moderately obese. There are some moderate risks.";
                            }
                            if (vki >= 31.2 && vki <= 45.4)
                            {
                                textBox2.Text = "Severely obese. There are high risks.";
                            }
                            if (vki > 45.4)
                            {
                                textBox2.Text = "Lethal obesity. There are very high risks.";
                            }
                        }
                        else if (lbl_cins.Text == "Cinsiyet    :")
                        {
                            if (vki < 20.7)
                            {
                                textBox2.Text = "Zayıflık. Düşük VKE de risk taşır.";
                            }
                            if (vki >= 20.7 && vki <= 26.4)
                            {
                                textBox2.Text = "VKE normal. Risk yok.";
                            }
                            if (vki >= 26.5 && vki <= 27.8)
                            {
                                textBox2.Text = "Şişmanlık sınırında. Küçük bir risk var.";
                            }
                            if (vki >= 27.9 && vki <= 31.1)
                            {
                                textBox2.Text = "Şişman. Orta derece risk var.";
                            }
                            if (vki >= 31.2 && vki <= 45.4)
                            {
                                textBox2.Text = "Ciddi şişmanlık. Yüksek derece risk var.";
                            }
                            if (vki > 45.4)
                            {
                                textBox2.Text = "Ölümcül şişmanlık. Çok büyük risk var.";
                            }
                        }
                        break;
                    case "Female":
                    case "Kadın":
                        if (lbl_cins.Text == "Gender    :")
                        {
                            if (vki < 19.1)
                            {
                                textBox2.Text = "Thinness. Small BMIs are also a risk.";
                            }
                            if (vki >= 19.1 && vki <= 25.8)
                            {
                                textBox2.Text = "Your BMI is normal. There is no risk.";
                            }
                            if (vki >= 25.9 && vki <= 27.3)
                            {
                                textBox2.Text = "Overweight. There is a small risk.";
                            }
                            if (vki >= 27.4 && vki <= 32.2)
                            {
                                textBox2.Text = "Moderately obese. There are some moderate risks.";
                            }
                            if (vki >= 32.3 && vki <= 44.8)
                            {
                                textBox2.Text = "Severely obese. There are high risks.";
                            }
                            if (vki > 44.8)
                            {
                                textBox2.Text = "Lethal obesity. There are very high risks.";
                            }
                        }
                        else if (lbl_cins.Text == "Cinsiyet    :")
                        {
                            if (vki < 19.1)
                            {
                                textBox2.Text = "Zayıflık. Düşük VKE de risk taşır.";
                            }
                            if (vki >= 19.1 && vki <= 25.8)
                            {
                                textBox2.Text = "VKE normal. Risk yok.";
                            }
                            if (vki >= 25.9 && vki <= 27.3)
                            {
                                textBox2.Text = "Şişmanlık sınırında. Küçük bir risk var.";
                            }
                            if (vki >= 27.4 && vki <= 32.2)
                            {
                                textBox2.Text = "Şişman. Orta derece risk var.";
                            }
                            if (vki >= 32.3 && vki <= 44.8)
                            {
                                textBox2.Text = "Ciddi şişmanlık. Yüksek derece risk var.";
                            }
                            if (vki > 44.8)
                            {
                                textBox2.Text = "Ölümcül şişmanlık. Çok büyük risk var.";
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_cins.Text == "Cinsiyet    :")
            {
                if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Environment.Exit(0);
            }
            else if (lbl_cins.Text == "Gender    :")
            {
                MessageBoxManager.Yes = "Yes";
                MessageBoxManager.No = "No";
                MessageBoxManager.Register();
                if (MessageBox.Show("Are you sure that you want to exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Environment.Exit(0);
                MessageBoxManager.Unregister();
            }
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lbl_cins.Text == "Cinsiyet    :")
            {
                MessageBox.Show("Programlayan : \nUtku Caner ATASEVER \nBaşkent Üniversitesi Elektrik-Elektronik Mühendisliği Bölümü Öğrencisi", "Hakkında");
            }
            else if (lbl_cins.Text == "Gender    :") 
            {
                MessageBox.Show("Coder : \nUtku Caner ATASEVER \nStudent of Başkent University Department of Electric-Electronical Engineering", "About");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RuntimeLocalizer.ChangeCulture(Form1.ActiveForm, "tr-TR");
            txt_boy.Text = "";
            txt_kilo.Text = "";
            textBox2.Text = "";
            cmb_cins.Items[0] = "Erkek";
            cmb_cins.Items[1] = "Kadın";
            cmb_cins.Text = "Seçiniz :";
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RuntimeLocalizer.ChangeCulture(Form1.ActiveForm, "en");
            txt_boy.Text = "";
            txt_kilo.Text = "";
            textBox2.Text = "";
            cmb_cins.Items[0] = "Male";
            cmb_cins.Items[1] = "Female";
            cmb_cins.Text = "Select :";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lbl_cins.Text == "Cinsiyet    :")
            {
                if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
            else if (lbl_cins.Text == "Gender    :")
            {
                MessageBoxManager.Yes = "Yes";
                MessageBoxManager.No = "No";
                MessageBoxManager.Register();
                if (MessageBox.Show("Are you sure that you want to exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    e.Cancel = false;
                else
                    e.Cancel = true;
                MessageBoxManager.Unregister();
            }
        }

        private void vKEHesabıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_cins.Text == "Cinsiyet    :")
            {
                MessageBox.Show("VKE nin formülü : kilonuz(kg)/boyunuzun karesi(m2) dir.", "Vücut Kitle Endeksi");
            }
            else if (lbl_cins.Text == "Gender    :")
            {
                MessageBox.Show("Formula of BMI : weight(kg)/the square of height(m2)", "Body Mass Index");
            }
        }

        private void idealKiloHesabıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_cins.Text == "Cinsiyet    :")
            {
                MessageBox.Show("İdeal kilonun formülü : Ulaşılmak istenen vke * boyun karesi(m2) dir.", "İdeal Kilo");
            }
            else if (lbl_cins.Text == "Gender    :")
            {
                MessageBox.Show("Formula of Ideal Weight : Desired BMI * the square of height(m2)", "Ideal Weight");
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_cins.Text == "Cinsiyet    :")
            {
                txt_boy.Text = "";
                txt_kilo.Text = "";
                textBox2.Text = "";
                txt_yil.Text = "Yıl";
                label3.Text = ".....";
                label5.Text = "..... kg";
                cmb_cins.Items[0] = "Erkek";
                cmb_cins.Items[1] = "Kadın";
                cmb_cins.Text = "Seçiniz :";
            }
            else if (lbl_cins.Text == "Gender    :")
            {
                txt_boy.Text = "";
                txt_kilo.Text = "";
                textBox2.Text = "";
                txt_yil.Text = "Year";
                label3.Text = ".....";
                label5.Text = "..... kg";
                cmb_cins.Items[0] = "Male";
                cmb_cins.Items[1] = "Female";
                cmb_cins.Text = "Select :";
            }
        }
    }
}