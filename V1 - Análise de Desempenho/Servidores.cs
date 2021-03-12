using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1___Análise_de_Desempenho
{
    class Servidores
    {

        public double lambda;
        public double mi;
        public double n;
        public double m;
        public double B;
        public double K;
        public double zero_n;
        public double N;

        //Sistema Clássico
        public void M_M_1(Label intensidade, Label prob_0_user, Label media_resposta, Label media_espera_fila, Label media_user, Label requisicao_fila, Label prob_n_req, Label utilizacao)
        {
            
            //Intensidade do tráfego:
            double p = lambda / mi;
            intensidade.Text = p.ToString();

            //Utilização:
            double U = p * 100;
            utilizacao.Text = U.ToString();

            //Probabilidade de ter n ou mais requisições no sistema:
            double p_n = Math.Pow(p, n);
            prob_n_req.Text = p_n.ToString();

            //Probabilidade de nenhum usuário no sistema:
            double p0 = 1 - p;
            prob_0_user.Text = p0.ToString();

            //Tempo médio de resposta:
            double E_s = 1 / (mi * (1 - p));
            media_resposta.Text = E_s.ToString();

            //Tempo médio de espera na fila:
            double E_w = E_s;
            media_espera_fila.Text = E_w.ToString();

            //Número médio de usuários:
            double E_n = p / (1 - p);
            media_user.Text = E_n.ToString();

            //Número médio de requisições na fila:
            double E_nw = (p * p) / (1 - p);
            requisicao_fila.Text = E_nw.ToString();
            
        }

        //m-Servidores
        public void M_M_m(Label intensidade, Label prob_0_user, Label media_resposta, Label media_espera_fila, Label media_user, Label requisicao_fila, Label prob_n_req, Label servidor_ocupado, Label nro_espera_requisicao, Label utilizacao)
        {

            if(0 <= n && n < m)
            {
                mi = n * mi;
            }
            if(m <= n)
            {
                mi = m * mi;
            }

            //Intensidade do tráfego:
            double p = lambda / (m * mi);
            intensidade.Text = p.ToString();

            //Utilização:
            double U = p * 100;
            utilizacao.Text = U.ToString();

            //Probabilidade de nenhum usuário no sistema:
            double p0 = 1 / (((Math.Pow((m * p), m)) / ((calcula_Fatorial(m)) * (1 - p))) + calcula_Somatoria(0, m, p));
            prob_0_user.Text = p0.ToString();

            //Probabilidade de ter n ou mais requisições no sistema:
            double p_n = 0;
            if (n <= m)
            {
                p_n = (Math.Pow((m * p), n) / calcula_Fatorial(n)) * p0;
            }
            else
            {
                p_n = ((Math.Pow(p, n) * Math.Pow(m, m)) / calcula_Fatorial(m)) * p0;
            }
            prob_n_req.Text = p_n.ToString();

            //Probabilidade de todos os servidores estarem ocupados:
            double p_fila = p0 * ((Math.Pow((m * p), m)) / ((calcula_Fatorial(m)) * (1 - p)));
            servidor_ocupado.Text = p_fila.ToString();

            //Tempo médio de resposta:
            double E_s = (1 / mi) * (1 + (p_fila / (m * (1 - p))));
            media_resposta.Text = E_s.ToString();

            //Tempo médio de espera na fila:
            double E_w = p_fila / (m * mi * (1 - p));
            media_espera_fila.Text = E_w.ToString();

            //Número esperado de requisições em atendimento:
            double E_ns = m * p;
            nro_espera_requisicao.Text = E_ns.ToString();

            //Número médio de usuários:
            double E_n = E_ns + (p_fila / (1 - p));
            media_user.Text = E_n.ToString();

            //Número médio de requisições na fila:
            double E_nw = p_fila / (1 - p);
            requisicao_fila.Text = E_nw.ToString();

        }

        //Infinitos Servidores
        public void M_M_INFINITO(Label intensidade, Label prob_n_req, Label media_user, Label media_resposta)
        {
           
            //Intensidade do tráfego:
            double p = lambda / mi;
            intensidade.Text = p.ToString();

            //Probabilidade de ter n ou mais requisições no sistema:
            double p_n = ((Math.Pow(p, n)) / (calcula_Fatorial(n))) * zero_n;
            prob_n_req.Text = p_n.ToString();

            //Número médio de usuários:
            double E_n = lambda / mi;
            media_user.Text = E_n.ToString();

            //Tempo médio de resposta:
            double E_s = 1 / mi;
            media_resposta.Text = E_s.ToString();

        }

        //Capacidade Finita
        public void M_M_1_B(Label intensidade, Label prob_0_user, Label prob_n_req, Label servidor_ocupado, Label taxa_perda, Label media_user, Label requisicao_fila, Label media_resposta, Label media_espera_fila, Label utilizacao, Label taxa_efct_chegada)
        {
            if(n >= B)
            {
                lambda = 0;
            }

            //Intensidade do tráfego:
            double p = lambda / mi;
            intensidade.Text = p.ToString();

            //Probabilidade de nenhum usuário no sistema:
            double p0 = (1 - p) / (1 - (Math.Pow(p, B + 1)));
            prob_0_user.Text = p0.ToString();

            //Probabilidade de ter n ou mais requisições no sistema:
            double p_n = 0;
            if (0 <= n && n <= B)
            {
                p_n = p0 * Math.Pow(p, n);
            }
            else
            {
                p_n = 0;
            }
            prob_n_req.Text = p_n.ToString();

            //Probabilidade de todos os servidores estarem ocupados:
            double p_fila = p0 * Math.Pow(p, B);
            servidor_ocupado.Text = p_fila.ToString();

            //Utilização:
            double U = p * (1 - p_fila);
            utilizacao.Text = U.ToString();

            //Taxa efetiva de chegada:
            double lambda_2 = lambda * (1 - p_fila);
            taxa_efct_chegada.Text = lambda_2.ToString();

            //Taxa de perda:
            double taxa_de_perda = lambda * p_fila;
            taxa_perda.Text = taxa_de_perda.ToString();

            //Número médio de usuários:
            double E_n = (p / (1 - p)) - (((B + 1) * ((Math.Pow(p, B + 1))) / (1 - (Math.Pow(p, B + 1)))));
            media_user.Text = E_n.ToString();

            //Número médio de requisições na fila:
            double E_nw = (p / (1 - p)) - (p * ((1 + (B * (Math.Pow(p, B)))) / (1 - (Math.Pow(p, B + 1)))));
            requisicao_fila.Text = E_nw.ToString();

            //Tempo médio de resposta:
            double E_s = E_n / (lambda * (1 - p_fila));
            media_resposta.Text = E_s.ToString();

            //Tempo médio de espera na fila:
            double E_w = E_nw / (lambda * (1 - p_fila));
            media_espera_fila.Text = E_w.ToString();
            
        }

        //m-Servidores com Capacidade Finita
        public void M_M_m_B(Label intensidade, Label prob_0_user, Label prob_n_req, Label servidor_ocupado, Label taxa_perda, Label media_user, Label requisicao_fila, Label media_resposta, Label media_espera_fila, Label utilizacao, Label taxa_efct_chegada)
        {
            if(n >= B)
            {
                lambda = 0;
            }

            //Intensidade do tráfego:
            double p = lambda / (m * mi);
            intensidade.Text = p.ToString();

            //Probabilidade de nenhum usuário no sistema:
            double p0 = 1 / (1 + (((1 - Math.Pow(p, B - m + 1)) * Math.Pow(m * p, m)) / (calcula_Fatorial(m) * (1 - p))) + calcula_Somatoria(1, m, p));
            prob_0_user.Text = p0.ToString();

            //Probabilidade de ter n ou mais requisições no sistema:
            double p_n = 0;
            if (n < m)
            {
                p_n = Math.Pow(lambda / mi, n) * (1 / calcula_Fatorial(n)) * p0;
            }
            if(m <= n && n <= B)
            {
                p_n = Math.Pow(lambda / mi, n) * (Math.Pow(m, m) / calcula_Fatorial(m)) * p0;
            }
            prob_n_req.Text = p_n.ToString();

            //Probabilidade de todos os servidores estarem ocupados:
            double p_fila = Math.Pow(lambda / mi, n) * (Math.Pow(m, B) / calcula_Fatorial(m)) * p0;
            servidor_ocupado.Text = p_fila.ToString();

            //Utilização:
            double U = p * (1 - p_fila);
            utilizacao.Text = U.ToString();

            //Taxa efetiva de chegada:
            double lambda_2 = lambda * (1 - p_fila);
            taxa_efct_chegada.Text = lambda_2.ToString();

            //Taxa de perda:
            double taxa_de_perda = lambda * p_fila;
            taxa_perda.Text = taxa_de_perda.ToString();

            //Número médio de usuários:
            double E_n = calcula_Somatoria(1, B, p_n);
            media_user.Text = E_n.ToString();

            //Número médio de requisições na fila:
            double E_nw = calcula_Somatoria(m, B, p_n);
            requisicao_fila.Text = E_nw.ToString();

            //Tempo médio de resposta:
            double E_s = E_n / (lambda * (1 - p_fila));
            media_resposta.Text = E_s.ToString();

            //Tempo médio de espera na fila:
            double E_w = E_nw / (lambda * (1 - p_fila));
            media_espera_fila.Text = E_w.ToString();

        }

        //População Finita com um Servidor:
        public void M_M_1_K(Label intensidade, Label prob_0_user, Label prob_n_req, Label media_user, Label requisicao_fila, Label media_resposta, Label media_espera_fila, Label utilizacao, Label taxa_efct_chegada)
        {
            if (n > K)
            {
                lambda = 0;
            }

            //Intensidade do tráfego:
            double p = lambda / mi;
            intensidade.Text = p.ToString();

            //Probabilidade de nenhum usuário no sistema:
            double p0 = 1 / calcula_Somatoria(0, K, K);
            prob_0_user.Text = p0.ToString();

            //Probabilidade de ter n ou mais requisições no sistema:
            double p_n = 0;
            if (0 <= n && n <= K)
            {
                p_n = Math.Pow(lambda / mi, n) * (calcula_Fatorial(K) / (calcula_Fatorial(K - n))) * p0;
            }
            if (n > K)
            {
                p_n = 0;
            }
            prob_n_req.Text = p_n.ToString();

            //Número médio de requisições na fila:
            double E_nw = K - (((lambda - mi) / lambda) * (1 - p0));
            requisicao_fila.Text = E_nw.ToString();

            //Número médio de usuários:
            double E_n = E_nw + (1 - p0);
            media_user.Text = E_n.ToString();

            //Utilização:
            double U = p * (K - E_n);
            utilizacao.Text = U.ToString();

            //Tempo médio de espera na fila:
            double E_w = E_nw / (lambda * (K - E_n));
            media_espera_fila.Text = E_w.ToString();

            //Tempo médio de resposta:
            double E_s = E_w + (1 / mi);
            media_resposta.Text = E_s.ToString();

            //Taxa efetiva de chegada:
            double lambda_2 = mi * (1 - p0);
            taxa_efct_chegada.Text = lambda_2.ToString();
            
        }

        //População Finita com Infinitos Servidores:
        public void M_M_INFINITO_K(Label intensidade, Label prob_0_user, Label prob_n_req, Label media_user)
        {
            if (n >= K)
            {
                lambda = 0;
            }

            //Intensidade do tráfego:
            double p = (K * lambda) / (1 + (lambda / mi));
            intensidade.Text = p.ToString();

            //Probabilidade de nenhum usuário no sistema:
            double p0 = 1 / Math.Pow(1 + (lambda / mi), K);
            prob_0_user.Text = p0.ToString();

            //Probabilidade de ter n ou mais requisições no sistema:
            double p_n = 0;
            if (0 <= n && n <= K)
            {
                p_n = (Math.Pow(lambda / mi, n) * analise_combinatoria(K, n)) / Math.Pow(1 + (lambda / mi), K);
            }
            if (n > K)
            {
                p_n = 0;
            }
            prob_n_req.Text = p_n.ToString();

            //Número médio de usuários:
            double E_n = (K * (lambda / mi)) / (1 + (lambda / mi));
            media_user.Text = E_n.ToString();

            

        }

        //m-Servidores com Capacidade e População Finitos
        //b-capacidade
        //k-populacao
        public void M_M_m_B_K(Label intensidade, Label utilizacao, Label taxa_efct_chegada, Label media_user, Label media_espera_fila, Label media_resposta, Label prob_n_req, Label servidor_ocupado)
        {
            if(n > B)
            {
                lambda = 0;
            }

            //Intensidade do tráfego:
            double p = lambda / (m * mi);
            intensidade.Text = p.ToString();

            //Probabilidade de ter n ou mais requisições no sistema:
            double p_n = 0;
            if (0 <= n && n <= m -1)
            {
                p_n = Math.Pow(lambda / mi, n) * analise_combinatoria(K, n) * zero_n;
            }
            if (m <= n && n <= K)
            {
                p_n = Math.Pow(lambda / mi, n) * analise_combinatoria(K, n) * ((calcula_Fatorial(n)) / (calcula_Fatorial(m))) * Math.Pow(m, m - n) * zero_n;
            }
            prob_n_req.Text = p_n.ToString();

            //Número médio de usuários:
            double E_n = calcula_Somatoria(0, m, p_n);
            media_user.Text = E_n.ToString();

            //Probabilidade de todos os servidores estarem ocupados:
            double p_fila = 0;
            if (0 <= n && n <= m - 1)
            {
                p_fila = Math.Pow(lambda / mi, B) * analise_combinatoria(K, B) * zero_n;
            }
            if (m <= n && n <= K)
            {
                p_fila = Math.Pow(lambda / mi, B) * analise_combinatoria(K, B) * ((calcula_Fatorial(B)) / (calcula_Fatorial(m))) * Math.Pow(m, m - B) * zero_n;
            }
            servidor_ocupado.Text = p_fila.ToString();

            //Utilização:
            double U = p * (K - E_n - (K - B) * p_fila);
            utilizacao.Text = U.ToString();

            //Taxa efetiva de chegada:
            double lambda_2 = lambda * (N - E_n);
            taxa_efct_chegada.Text = lambda_2.ToString();

            //Tempo médio de espera na fila:
            double E_w = E_n / lambda_2;
            media_espera_fila.Text = E_w.ToString();

            //Tempo médio de resposta:
            double E_s = E_n / (lambda * (K - E_n - ((K - B) * p * B)));
            media_resposta.Text = E_s.ToString();

        }

        public double calcula_Fatorial(double numero)
        {
            double fatorial = 1;

            if (numero == 0)
            {
                fatorial = 1;
            }
            else {
                for (int i = 1; i <= numero; i++)
                {
                    fatorial *= i;
                }
            }

            return fatorial;
        }

        public double calcula_Somatoria(double limite_inferior, double limite_superior, double valor)
        {
            double soma = 0;
             
            if(limite_superior == m)
            {
                for (double i = limite_inferior; i <= limite_superior - 1; i++)
                {
                    soma += (Math.Pow((m * valor), i)) / (calcula_Fatorial(i));

                }
            }

            if(limite_superior == B)
            {
                for (double i = limite_inferior; i <= limite_superior; i++)
                {
                    soma += i * valor;

                }
            }

            if(limite_inferior == m && limite_superior == B)
            {
                for (double i = limite_inferior + 1; i <= limite_superior; i++)
                {
                    soma += (i - m) * valor;

                }
            }

            if(limite_superior == K)
            {
                for (double i = limite_inferior; i <= limite_superior; i++)
                {
                    soma += Math.Pow(lambda / mi, i) * (calcula_Fatorial(valor) / (calcula_Fatorial(valor - i)));

                }
            }

            if(limite_superior == m && limite_inferior == 0)
            {
                for (double i = limite_inferior; i <= limite_superior; i++)
                {
                    soma += i * valor;

                }
            }

            return soma;

        }

        public double analise_combinatoria(double valor_1, double valor_2)
        {
            double resultado = 0;

            resultado = calcula_Fatorial(valor_1) / (calcula_Fatorial(valor_2) * calcula_Fatorial(valor_1 - valor_2));

            return resultado;
        }
        
    }
}
