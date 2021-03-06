﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URIdreieckGUI
{
    public partial class URIForm : Form
    {
        public URIForm()
        {
            InitializeComponent();
            //            moreComponents();
            //            test(label26);
            test(label26);
        }

        public string versionNum = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        internal string versionTxT = $"Created by AlexB - 2015 - v.";

        internal void test(Label a)
        {
            a.Text = $"{versionTxT}{versionNum }";
        }

        /* %%%%%%%%%%%%%%%%%%%%%%%%%%% U-R-I - Deklare %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/

        //  Tab1 U-R-I - Deklare
        private double anDoubleR, anDoubleI, anDoubleU, pvE;

        /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/

        //  Tab2 Arithmetik - Deklare
        private string pGRAo;

        private double aDvGRA1, aDvGRA2, pGRAe, pGRAeR;
        private int pGRAgE;
        /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/

        //  Tab3 Fahrenheit - Deklare
        private double aDvFc, aDvFfe;

        /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/

        //  Tab4  Gewitter   -   Deklare
        private double aDvGt, vGv, aDvGk;

        /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/
        //  Tab 1   -   U-R-I

        private void tb1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                anDoubleR = Convert.ToDouble(tb1.Text);
                anDoubleR = double.Parse(tb1.Text);
            }
            catch (FormatException)
            {
                tb1.Clear();
            }
        }

        private void tb2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                anDoubleI = Convert.ToDouble(tb2.Text);
                anDoubleI = double.Parse(tb2.Text);
            }
            catch (FormatException)
            {
                tb2.Clear();
            }
        }

        /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/

        //  Tab2 - GRA Arithmetik
        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void vGRA1_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    aDvGRA1 = Convert.ToDouble(vGRA1.Text);
                    aDvGRA1 = double.Parse(vGRA1.Text);
                }
                catch (FormatException)
                {
                    vGRA1.Clear();
                }
            }
        }

        private void vGRA2_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    aDvGRA2 = Convert.ToDouble(vGRA2.Text);
                    aDvGRA2 = double.Parse(vGRA2.Text);
                }
                catch (FormatException)
                {
                    vGRA2.Clear();
                }
            }
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            this.VersionField.Text = versionTxT;
            this.VersionField.Visible = true;
        }

        private void tabPage5_MouseHover(object sender, EventArgs e)
        {
            this.VersionField.Text = versionTxT;
            this.VersionField.Visible = true;
        }

        private void URIForm_Load(object sender, EventArgs e)
        {
            this.VersionField.Text = versionTxT;
            this.VersionField.Visible = true;
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            this.tb1.Enabled = true;
            this.tb2.Enabled = true;
            //          this.tb3.Enabled = true;
            this.tb4.Enabled = false;
            tb4.Clear();
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            this.tb1.Enabled = true;
            this.tb2.Enabled = false;
            //          this.tb3.Enabled = true;
            this.tb4.Enabled = true;
            tb2.Clear();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            this.tb1.Enabled = false;
            this.tb2.Enabled = true;
            //          this.tb3.Enabled = true;
            this.tb4.Enabled = true;
            tb1.Clear();
        }

        private void deCodeB64_Click(object sender, EventArgs e)
        {
            try
            { 
                byte[] data = Convert.FromBase64String(inputBase64.Text);
                string decodedString = Encoding.UTF8.GetString(data);
                outBase64.Text = decodedString;
            }
            catch { MessageBox.Show("Not convertible!");}
        }

        private void decodeReset_Click(object sender, EventArgs e)
        {
            inputBase64.Clear();
            outBase64.Clear();
        }

        private void pastIN_Click(object sender, EventArgs e)
        {
            inputBase64.Text += Clipboard.GetText();
        }

        private void pastEnBase64_Click(object sender, EventArgs e)
        {
            tbInEnBase64.Text += Clipboard.GetText();
        }

        private void btEnBase64_Click(object sender, EventArgs e)
        {
            tbOutEnBase64.Text = Base64Encode(tbInEnBase64.Text);        
        }

        public static string Base64Encode(string plainText)
        {
            byte[] byteText = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(byteText);
        }

        private void btResetEnBase64_Click(object sender, EventArgs e)
        {
            tbInEnBase64.Clear();
            tbOutEnBase64.Clear();
        }

        private void copyBase64_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbOutEnBase64.Text);
        }

        private void copyText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outBase64.Text);
        }


        /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/

        //  Tab 3   -   Fahrenheit
        private void fFbtn1_Click(object sender, EventArgs e)
        {
            aDvFfe = (aDvFc * 1.8) + 32;
            this.vFf.Text = aDvFfe.ToString();
        }

        private void vFc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                aDvFc = Convert.ToDouble(vFc.Text);
                anDoubleR = double.Parse(vFc.Text);
            }
            catch (FormatException)
            {
                vFc.Clear();
            }
        }

        /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/
        //  Tab4    -   Gewitter

        private void vGt_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    aDvGt = Convert.ToDouble(vGt.Text);
                    aDvGt = double.Parse(vGt.Text);
                }
                catch (FormatException)
                {
                    vGt.Clear();
                }
            }
        }

        private void vGtemp_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    aDvGk = Convert.ToDouble(vGtemp.Text);
                    aDvGk = double.Parse(vGtemp.Text);
                }
                catch (FormatException)
                {
                    vGtemp.Clear();
                }
            }
        }

        private void vGbtn1_Click(object sender, EventArgs e)
        {
            vGv = (331.6 + (0.6 * aDvGk));
            vGe.Text = Convert.ToString(aDvGt * vGv) + " m";
            vGeKM.Text = Convert.ToString((aDvGt * vGv) / 1000) + " km";
        }

        private void tb4_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                anDoubleU = Convert.ToDouble(tb4.Text);
                anDoubleU = double.Parse(tb4.Text);
            }
            catch (FormatException)
            {
                tb4.Clear();
            }
        }

        /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/

        // Button Operation
        //  Berechnen
        private void btn1_Click(object sender, EventArgs e)
        {
            // Tab1 - U-R-I
            if (rb3.Checked == true)                                //Spannung berechnen
            {
                pvE = anDoubleR * anDoubleI;
                this.vEe.Text = "in V";
            }
            else if (rb2.Checked == true)                           // Strom berechnen
            {
                pvE = anDoubleU / anDoubleR;
                this.vEe.Text = "in A";
            }
            else if (rb1.Checked == true)                                                  // Widerstand berechnen
            {
                pvE = anDoubleU / anDoubleI;
                this.vEe.Text = "in \u2126";
            }
            // Tab2 -
            else if (rbGRAa.Checked == true)                                          // Addition
            {
                pGRAe = aDvGRA1 + aDvGRA2;
                pGRAo = " + ";
            }
            else if (rbGRAs.Checked == true)                                          // Subtraktion
            {
                pGRAe = aDvGRA1 - aDvGRA2;
                pGRAo = " - ";
            }
            else if (rbGRAm.Checked == true)                                                  // Multiplikation
            {
                pGRAe = aDvGRA1 * aDvGRA2;
                pGRAo = " * ";
            }
            else if (rbGRAd.Checked == true)                                                  // Division
            {
                pGRAe = aDvGRA1 / aDvGRA2;
                pGRAeR = aDvGRA1 % aDvGRA2;
                pGRAgE = Convert.ToInt32(pGRAe);
                pGRAo = " / ";
                this.vGRAgE.Text = pGRAgE.ToString();
                this.vGRAeR.Text = pGRAeR.ToString();
            }

            // Tab1 URI
            this.tb3.Text = pvE.ToString();
            // Tab2 Grundrechenarten
            this.vGRAe.Text = pGRAe.ToString();
            this.vGRAo.Text = pGRAo;
        }

        //  Reset
        private void btn2_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            tb1.Enabled = true;
            tb2.Enabled = true;
            //          this.tb3.Enabled = true;
            tb4.Enabled = true;
            //  Tab 2 - Clear
            vGRA1.Clear();
            vGRA2.Clear();
            vGRA1.Clear();
            vGRAe.Clear();
            vGRAeR.Clear();
            vGRAgE.Clear();
            rbGRAa.Checked = false;
            rbGRAd.Checked = false;
            rbGRAs.Checked = false;
            rbGRAm.Checked = false;
            //  Tab 3 - Clear
            vFc.Clear();
            vFf.Clear();
            //   Tab 4 - Clear
            tb4.Clear();
            vGt.Clear();
            vGe.Clear();
            vGeKM.Clear();
            vGtemp.Text = "10 °";
        }

        //  Schließen
        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vielen Dank für die Nutzung dieses Programmes :)");
            Environment.Exit(0);
        }
    }
}