using System;
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
        }

        /* %%%%%%%%%%%%%%%%%%%%%%%%%%% U-R-I - Deklare %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/
        //  Tab1 U-R-I - Deklare
        double anDoubleR, anDoubleI, anDoubleU, pvE;

        /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/
        //  Tab2 Arithmetik - Deklare
        string pGRAo;
        double aDvGRA1, aDvGRA2, pGRAe, pGRAeR;
        int pGRAgE;
        /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/
        //  Tab3 Fahrenheit - Deklare
        double aDvFc, aDvFfe;
        /* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/

       
        //  Tab4  Gewitter   -   Deklare
        double aDvGt, vGv, aDvGk;


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


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
            vGv = (331.6+(0.6*aDvGk));
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
                //  Tab 2 - Clear
            vGRA1.Clear();
            vGRA2.Clear();
            vGRA1.Clear();
            vGRAe.Clear();
            vGRAeR.Clear();
            vGRAgE.Clear();
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
