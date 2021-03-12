namespace V1___Análise_de_Desempenho
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_lambda = new System.Windows.Forms.TextBox();
            this.text_mi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.intensidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prob_0_user = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.media_resposta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.media_espera_fila = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.media_user = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.requisicao_fila = new System.Windows.Forms.Label();
            this.text_n = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prob_n_req = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.text_servidores = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.text_capacidade = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.text_populacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.servidor_ocupado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nro_espera_requisicao = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.text_0_clientes = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.taxa_perda = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.utilizacao = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.taxa_efct_chegada = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.text_clientes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_lambda
            // 
            this.text_lambda.Enabled = false;
            this.text_lambda.Location = new System.Drawing.Point(24, 108);
            this.text_lambda.Name = "text_lambda";
            this.text_lambda.Size = new System.Drawing.Size(121, 20);
            this.text_lambda.TabIndex = 0;
            this.text_lambda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_mi
            // 
            this.text_mi.Enabled = false;
            this.text_mi.Location = new System.Drawing.Point(24, 157);
            this.text_mi.Name = "text_mi";
            this.text_mi.Size = new System.Drawing.Size(121, 20);
            this.text_mi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // intensidade
            // 
            this.intensidade.AutoSize = true;
            this.intensidade.Location = new System.Drawing.Point(708, 9);
            this.intensidade.Name = "intensidade";
            this.intensidade.Size = new System.Drawing.Size(35, 13);
            this.intensidade.TabIndex = 3;
            this.intensidade.Text = "label1";
            this.intensidade.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Intensidade de tráfico: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Probabilidade de nenhum usuário no sistema:";
            // 
            // prob_0_user
            // 
            this.prob_0_user.AutoSize = true;
            this.prob_0_user.Location = new System.Drawing.Point(708, 72);
            this.prob_0_user.Name = "prob_0_user";
            this.prob_0_user.Size = new System.Drawing.Size(35, 13);
            this.prob_0_user.TabIndex = 5;
            this.prob_0_user.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tempo médio de resposta:";
            // 
            // media_resposta
            // 
            this.media_resposta.AutoSize = true;
            this.media_resposta.Location = new System.Drawing.Point(705, 108);
            this.media_resposta.Name = "media_resposta";
            this.media_resposta.Size = new System.Drawing.Size(35, 13);
            this.media_resposta.TabIndex = 7;
            this.media_resposta.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tempo médio de espera na fila:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // media_espera_fila
            // 
            this.media_espera_fila.AutoSize = true;
            this.media_espera_fila.Location = new System.Drawing.Point(708, 131);
            this.media_espera_fila.Name = "media_espera_fila";
            this.media_espera_fila.Size = new System.Drawing.Size(35, 13);
            this.media_espera_fila.TabIndex = 9;
            this.media_espera_fila.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Número médio de usuários:";
            // 
            // media_user
            // 
            this.media_user.AutoSize = true;
            this.media_user.Location = new System.Drawing.Point(708, 163);
            this.media_user.Name = "media_user";
            this.media_user.Size = new System.Drawing.Size(35, 13);
            this.media_user.TabIndex = 11;
            this.media_user.Text = "label1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(519, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Número médio de requisições na fila:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // requisicao_fila
            // 
            this.requisicao_fila.AutoSize = true;
            this.requisicao_fila.Location = new System.Drawing.Point(705, 186);
            this.requisicao_fila.Name = "requisicao_fila";
            this.requisicao_fila.Size = new System.Drawing.Size(35, 13);
            this.requisicao_fila.TabIndex = 13;
            this.requisicao_fila.Text = "label1";
            // 
            // text_n
            // 
            this.text_n.Enabled = false;
            this.text_n.Location = new System.Drawing.Point(24, 217);
            this.text_n.Name = "text_n";
            this.text_n.Size = new System.Drawing.Size(121, 20);
            this.text_n.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Probabilidade de ter n ou mais requisições no sistema:";
            // 
            // prob_n_req
            // 
            this.prob_n_req.AutoSize = true;
            this.prob_n_req.Location = new System.Drawing.Point(708, 43);
            this.prob_n_req.Name = "prob_n_req";
            this.prob_n_req.Size = new System.Drawing.Size(23, 13);
            this.prob_n_req.TabIndex = 18;
            this.prob_n_req.Text = "lbl1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Lambda:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Mi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Número de Requisições";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tipo do Servidor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(184, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Número de Servidores";
            // 
            // text_servidores
            // 
            this.text_servidores.Enabled = false;
            this.text_servidores.Location = new System.Drawing.Point(187, 105);
            this.text_servidores.Name = "text_servidores";
            this.text_servidores.Size = new System.Drawing.Size(121, 20);
            this.text_servidores.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(184, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Capacidade do Sistema";
            // 
            // text_capacidade
            // 
            this.text_capacidade.Enabled = false;
            this.text_capacidade.Location = new System.Drawing.Point(187, 163);
            this.text_capacidade.Name = "text_capacidade";
            this.text_capacidade.Size = new System.Drawing.Size(121, 20);
            this.text_capacidade.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(179, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Tamanho da População";
            // 
            // text_populacao
            // 
            this.text_populacao.Enabled = false;
            this.text_populacao.Location = new System.Drawing.Point(182, 217);
            this.text_populacao.Name = "text_populacao";
            this.text_populacao.Size = new System.Drawing.Size(126, 20);
            this.text_populacao.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Probabilidade de todos os servidores estarem ocupados:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // servidor_ocupado
            // 
            this.servidor_ocupado.AutoSize = true;
            this.servidor_ocupado.Location = new System.Drawing.Point(708, 220);
            this.servidor_ocupado.Name = "servidor_ocupado";
            this.servidor_ocupado.Size = new System.Drawing.Size(35, 13);
            this.servidor_ocupado.TabIndex = 31;
            this.servidor_ocupado.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Número esperado de requisições em atendimento:";
            // 
            // nro_espera_requisicao
            // 
            this.nro_espera_requisicao.AutoSize = true;
            this.nro_espera_requisicao.Location = new System.Drawing.Point(708, 243);
            this.nro_espera_requisicao.Name = "nro_espera_requisicao";
            this.nro_espera_requisicao.Size = new System.Drawing.Size(35, 13);
            this.nro_espera_requisicao.TabIndex = 33;
            this.nro_espera_requisicao.Text = "label1";
            this.nro_espera_requisicao.UseWaitCursor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Probabilidade de não existirem clientes";
            // 
            // text_0_clientes
            // 
            this.text_0_clientes.Enabled = false;
            this.text_0_clientes.Location = new System.Drawing.Point(24, 276);
            this.text_0_clientes.Name = "text_0_clientes";
            this.text_0_clientes.Size = new System.Drawing.Size(121, 20);
            this.text_0_clientes.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(623, 276);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Taxa de perda:";
            // 
            // taxa_perda
            // 
            this.taxa_perda.AutoSize = true;
            this.taxa_perda.Location = new System.Drawing.Point(708, 279);
            this.taxa_perda.Name = "taxa_perda";
            this.taxa_perda.Size = new System.Drawing.Size(35, 13);
            this.taxa_perda.TabIndex = 37;
            this.taxa_perda.Text = "label1";
            this.taxa_perda.UseWaitCursor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(643, 301);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Utilização:";
            // 
            // utilizacao
            // 
            this.utilizacao.AutoSize = true;
            this.utilizacao.Location = new System.Drawing.Point(708, 301);
            this.utilizacao.Name = "utilizacao";
            this.utilizacao.Size = new System.Drawing.Size(35, 13);
            this.utilizacao.TabIndex = 39;
            this.utilizacao.Text = "label1";
            this.utilizacao.UseWaitCursor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(567, 329);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Taxa efetiva de chegada:";
            // 
            // taxa_efct_chegada
            // 
            this.taxa_efct_chegada.AutoSize = true;
            this.taxa_efct_chegada.Location = new System.Drawing.Point(708, 329);
            this.taxa_efct_chegada.Name = "taxa_efct_chegada";
            this.taxa_efct_chegada.Size = new System.Drawing.Size(35, 13);
            this.taxa_efct_chegada.TabIndex = 41;
            this.taxa_efct_chegada.Text = "label1";
            this.taxa_efct_chegada.UseWaitCursor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(216, 260);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 13);
            this.label21.TabIndex = 44;
            this.label21.Text = "Número de Clientes";
            // 
            // text_clientes
            // 
            this.text_clientes.Enabled = false;
            this.text_clientes.Location = new System.Drawing.Point(182, 279);
            this.text_clientes.Name = "text_clientes";
            this.text_clientes.Size = new System.Drawing.Size(121, 20);
            this.text_clientes.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.text_clientes);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.taxa_efct_chegada);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.utilizacao);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.taxa_perda);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.text_0_clientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nro_espera_requisicao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.servidor_ocupado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.text_populacao);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.text_capacidade);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.text_servidores);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prob_n_req);
            this.Controls.Add(this.text_n);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.requisicao_fila);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.media_user);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.media_espera_fila);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.media_resposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prob_0_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intensidade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_mi);
            this.Controls.Add(this.text_lambda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_lambda;
        private System.Windows.Forms.TextBox text_mi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label intensidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label prob_0_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label media_resposta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label media_espera_fila;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label media_user;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label requisicao_fila;
        private System.Windows.Forms.TextBox text_n;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label prob_n_req;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox text_servidores;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox text_capacidade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox text_populacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label servidor_ocupado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nro_espera_requisicao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox text_0_clientes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label taxa_perda;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label utilizacao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label taxa_efct_chegada;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox text_clientes;
    }
}

