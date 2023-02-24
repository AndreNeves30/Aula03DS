using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03DS
{
    public partial class FormCombinacoes : Form
    {
        private void verifica()
        {
            if (!chkGarnet.Checked && !chkPerola.Checked && !chkAmetista.Checked)
            {
                labelTexto.Text = "Tem ninguem aqui não";
                pictureBoxFormas.Image = null;
            }
            else if (chkGarnet.Checked && !chkPerola.Checked && !chkAmetista.Checked)
            {
                labelTexto.Text = "Garnet";
                pictureBoxFormas.Image = Properties.Resources.ganet1;
            }
            else if (!chkGarnet.Checked && !chkPerola.Checked && chkAmetista.Checked)
            {
                labelTexto.Text = "Ametista";
                pictureBoxFormas.Image = Properties.Resources.ametista1;
            }
            else if (!chkGarnet.Checked && chkPerola.Checked && !chkAmetista.Checked)
            {
                labelTexto.Text = "Perola";
                pictureBoxFormas.Image = Properties.Resources.perola1;
            }
            else if (chkGarnet.Checked && chkPerola.Checked && !chkAmetista.Checked)
            {   
                labelTexto.Text = "Sardonyx";
                pictureBoxFormas.Image = Properties.Resources.sardonyx1;
            }
            else if (chkGarnet.Checked && !chkPerola.Checked && chkAmetista.Checked)
            {
                labelTexto.Text = "Sugallite";
                pictureBoxFormas.Image = Properties.Resources.sugallite2;
            }
            else if (!chkGarnet.Checked && chkPerola.Checked && chkAmetista.Checked)
            {
                labelTexto.Text = "Opal";
                pictureBoxFormas.Image = Properties.Resources.opal1;
            }
            else if (chkGarnet.Checked && chkPerola.Checked && chkAmetista.Checked)
            {
                labelTexto.Text = "Alexandrite";
                pictureBoxFormas.Image = Properties.Resources.alexandrite1;
            }




        }

        public FormCombinacoes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkGarnet_CheckedChanged(object sender, EventArgs e)
        {
            verifica();
        }

        private void chkPerola_CheckedChanged(object sender, EventArgs e)
        {
            verifica();
        }

        private void chkAmetista_CheckedChanged(object sender, EventArgs e)
        {
            verifica();
        }
    }
}
