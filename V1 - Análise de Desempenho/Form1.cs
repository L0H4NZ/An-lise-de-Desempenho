using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1___Análise_de_Desempenho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String[] filas = new string[]{"Fila Clássica", "M-Servidores", "Infinitos Servidores", "Capacidade Finita","M-Servidores Capacidade Finita",
                "População Finita c/ 1 Servidor", "População Fininita c/ infin. Serv.", "M-Servidores c/ cap e População Finitos."};
            for (int i = 0; i < 8; i++)
            {
                comboBox1.Items.Add(filas[i]);
            }
        }

        Servidores servidores = new Servidores();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            servidores.lambda = Convert.ToDouble(text_lambda.Text);
            servidores.mi = Convert.ToDouble(text_mi.Text);
            servidores.n = Convert.ToDouble(text_n.Text.Length > 0 ? text_n.Text : "0");
            servidores.m = Convert.ToDouble(text_servidores.Text.Length > 0 ? text_servidores.Text : "0");
            servidores.B = Convert.ToDouble(text_capacidade.Text.Length > 0 ? text_capacidade.Text : "0");
            servidores.K = Convert.ToDouble(text_populacao.Text.Length > 0 ? text_populacao.Text : "0");
            servidores.zero_n = Convert.ToDouble(text_0_clientes.Text.Length > 0 ? text_0_clientes.Text : "0");
            servidores.N = Convert.ToDouble(text_clientes.Text.Length > 0 ? text_clientes.Text : "0");

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    servidores.M_M_1(intensidade, prob_0_user, media_resposta, media_espera_fila, media_user, requisicao_fila, prob_n_req, utilizacao);
                    break;

                case 1:
                    servidores.M_M_m(intensidade, prob_0_user, media_resposta, media_espera_fila, media_user, requisicao_fila, prob_n_req, servidor_ocupado, nro_espera_requisicao, utilizacao);
                    break;

                case 2:
                    servidores.M_M_INFINITO(intensidade, prob_n_req, media_user, media_resposta);
                    break;

                case 3:
                    servidores.M_M_1_B(intensidade, prob_0_user, prob_n_req, servidor_ocupado, taxa_perda, media_user, requisicao_fila, media_resposta, media_espera_fila, utilizacao, taxa_efct_chegada);
                    break;

                case 4:
                    servidores.M_M_m_B(intensidade, prob_0_user, prob_n_req, servidor_ocupado, taxa_perda, media_user, requisicao_fila, media_resposta, media_espera_fila, utilizacao, taxa_efct_chegada);
                    break;

                case 5:
                    servidores.M_M_1_K(intensidade, prob_0_user, prob_n_req, media_user, requisicao_fila, media_resposta, media_espera_fila, utilizacao, taxa_efct_chegada);
                    break;

                case 6:
                    servidores.M_M_INFINITO_K(intensidade, prob_0_user, prob_n_req, media_user);
                    break;

                case 7:
                    servidores.M_M_m_B_K(intensidade, utilizacao, taxa_efct_chegada, media_user, media_espera_fila, media_resposta, prob_n_req, servidor_ocupado);
                    break;

                default:
                    break;
            }

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void habilitaTexts(TextBox[] txt) {
            for (int i = 0; i < txt.Length; i++) {
                txt[i].Enabled = true;
            }
        }
        private void desabilitaTexts(TextBox[] txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i].Enabled = false;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch ((sender as ComboBox).SelectedIndex)
            {
                case 0:
                    habilitaTexts(new TextBox[]{text_lambda, text_mi, text_n});
                    break;

                case 1:
                    habilitaTexts(new TextBox[] { text_lambda, text_mi, text_servidores });
                    break;

                case 2:
                    habilitaTexts(new TextBox[] { text_lambda, text_mi, text_n, text_0_clientes });
                    break;

                case 3:
                    habilitaTexts(new TextBox[] { text_lambda, text_mi, text_capacidade, text_n });
                    break;

                case 4:
                    habilitaTexts(new TextBox[] { text_lambda, text_mi, text_servidores, text_capacidade, text_n });
                    break;

                case 5:
                    habilitaTexts(new TextBox[] { text_lambda, text_mi, text_populacao , text_n });
                    break;

                case 6:
                    habilitaTexts(new TextBox[] { text_lambda, text_mi, text_populacao, text_n });
                    break;

                case 7:
                    habilitaTexts(new TextBox[] { text_lambda, text_mi, text_populacao, text_n, text_capacidade, text_0_clientes, text_servidores, text_clientes });
                    break;

                default:
                    break;
            }
              
              
               
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
