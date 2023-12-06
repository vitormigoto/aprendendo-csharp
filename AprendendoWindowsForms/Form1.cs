using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendendoWindowsForms
{
    public partial class frm_inicio : Form
    {

        public frm_inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void novoTreinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            char virgula = ',';
            if(float.Parse(lbl_display.Text) != 0 || lbl_display.Text.Contains(virgula)) 
                lbl_display.Text = lbl_display.Text + "0";
                        
        }

        

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_num1.Text = "0";
            txt_num2.Text = "0";
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            executaOperacao("soma");
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {

        }

        public void executaOperacao(string valor)
        {
            if(txt_num1.Text== "" || txt_num2.Text == "")
            {
                MessageBox.Show("É preciso ter valores dentro das caixas.");
            }
            else
            {
                if (valor == "soma")
                {
                    lbl_display.Text = (float.Parse(txt_num1.Text) + float.Parse(txt_num2.Text)).ToString();
                }
                else if (valor == "sub")
                {
                    lbl_display.Text = (float.Parse(txt_num1.Text) - float.Parse(txt_num2.Text)).ToString();
                }
                else if (valor == "div")
                {
                    if (float.Parse(txt_num2.Text) == 0)
                    {
                        MessageBox.Show("Não é possivel executar divisão por zero");
                    }
                    else
                    {
                        lbl_display.Text = (float.Parse(txt_num1.Text) / float.Parse(txt_num2.Text)).ToString();
                    }
                }
                else if (valor == "mult")
                {
                    lbl_display.Text = (float.Parse(txt_num1.Text) * float.Parse(txt_num2.Text)).ToString();
                }
            }
        }

        private void lbl_display_Click(object sender, EventArgs e)
        {

        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            executaOperacao("div");
        }

        private void btn_vezes_Click(object sender, EventArgs e)
        {
            executaOperacao("mult");
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            executaOperacao("sub");
        }
    }
}
