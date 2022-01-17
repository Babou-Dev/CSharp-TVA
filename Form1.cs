using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculTVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            if (rb_bel.Checked == true)
            {
                rb_21.Visible = true;
                rb_12.Visible = true;
                rb_6.Visible = true;

                rb_17.Visible = false;
                rb_14.Visible = false;
                rb_8.Visible = false;
                rb_3.Visible = false;

                rb_20.Visible = false;
                rb_10.Visible = false;
                rb_55.Visible = false;
                rb_21fr.Visible = false;
            }
            else if (rb_lux.Checked == true)
            {
                rb_17.Visible = true;
                rb_14.Visible = true;
                rb_8.Visible = true;
                rb_3.Visible = true;

                rb_21.Visible = false;
                rb_12.Visible = false;
                rb_6.Visible = false;

                rb_20.Visible = false;
                rb_10.Visible = false;
                rb_55.Visible = false;
                rb_21fr.Visible = false;
            }
            else if (rb_fr.Checked == true)
            {
                rb_20.Visible = true;
                rb_10.Visible = true;
                rb_55.Visible = true;
                rb_21fr.Visible = true;

                rb_21.Visible = false;
                rb_12.Visible = false;
                rb_6.Visible = false;

                rb_17.Visible = false;
                rb_14.Visible = false;
                rb_8.Visible = false;
                rb_3.Visible = false;
            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if (rb_htva.Checked == true)
            {
                tva_calc();
            } else
            {
                htva_calc();
            }
        }

        public void tva_calc()
        {
            double prixhtva = Convert.ToDouble(tb_htva.Text);
            double tauxtva = 0;
            double prixtva = 0;

            if (rb_21.Checked == true)
            {
                prixtva = prixhtva + prixhtva * 0.21;
                tauxtva = prixhtva * 0.21;
            }
            else if (rb_12.Checked == true)
            {
                prixtva = prixhtva + prixhtva * 0.12;
                tauxtva = prixhtva * 0.12;
            }
            else if (rb_6.Checked == true)
            {
                prixtva = prixhtva + prixhtva * 0.06;
                tauxtva = prixhtva * 0.06;
            }
            else if (rb_20.Checked == true)
            {
                prixtva = prixhtva + prixhtva * 0.20;
                tauxtva = prixhtva * 0.20;
            }
            else if (rb_10.Checked == true)
            {
                prixtva = prixhtva + prixhtva * 0.10;
                tauxtva = prixhtva * 0.10;
            }
            else if (rb_55.Checked == true)
            {
                prixtva = prixhtva + prixhtva * 0.055;
                tauxtva = prixhtva * 0.055;
            }
            else if (rb_21fr.Checked == true)
            {
                prixtva = prixhtva + prixhtva * 0.021;
                tauxtva = prixhtva * 0.021;
            }
            else if (rb_17.Checked == true)
            {
                prixtva = prixhtva + prixhtva * 0.17;
                tauxtva = prixhtva * 0.17;
            }
            else if (rb_14.Checked == true)
            {
                prixtva = prixhtva + prixhtva * 0.14;
                tauxtva = prixhtva * 0.14;
            }
            else if (rb_8.Checked == true)
            {
                prixtva = prixhtva + prixhtva * 0.08;
                tauxtva = prixhtva * 0.08;
            }
            else if (rb_3.Checked == true)
            {
                prixtva = prixhtva + prixhtva * 0.03;
                tauxtva = prixhtva * 0.03;
            }
            MessageBox.Show("Le prix TVAC est de " + prixtva + " € et le montant de tva appliqué est de " + tauxtva + " €", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void htva_calc()
        {
            double prixHT = 0;
            double prixTVAC = Convert.ToDouble(tb_tvac.Text);

            if (rb_21.Checked == true)
            {
                prixHT = prixTVAC / 1.21;
            }
            else if (rb_12.Checked == true)
            {
                prixHT = prixTVAC / 1.12;
            }
            else if (rb_6.Checked == true)
            {
                prixHT = prixTVAC / 1.06;
            }
            else if (rb_20.Checked == true)
            {
                prixHT = prixTVAC / 1.20;
            }
            else if (rb_10.Checked == true)
            {
                prixHT = prixTVAC / 1.10;
            }
            else if (rb_55.Checked == true)
            {
                prixHT = prixTVAC / 1.055;
            }
            else if (rb_21fr.Checked == true)
            {
                prixHT = prixTVAC / 1.021;
            }
            else if (rb_17.Checked == true)
            {
                prixHT = prixTVAC / 1.17;
            }
            else if (rb_14.Checked == true)
            {
                prixHT = prixTVAC / 1.14;
            }
            else if (rb_8.Checked == true)
            {
                prixHT = prixTVAC / 1.08;
            }
            else if (rb_3.Checked == true)
            {
                prixHT = prixTVAC / 1.03;
            }
            MessageBox.Show("Le prix HTVA est de " + prixHT + " €", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
