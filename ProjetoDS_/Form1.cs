using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using ProjetoDS_EAD;

namespace ProjetoDS_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            try
            {
                DTO_Login obj = new DTO_Login();
                obj.Usuario = Email.Text;
                obj.Senha = Senha.Text;
                DTO_Usuario obj2 = new DTO_Usuario();

                obj2 = BLL_Login.ValidarLogin(obj);
                if (obj2.StatusLogin == true)
                {
                    if (obj2.Ativo != "ativo")
                    {
                        MessageBox.Show("Seu usuário está desativado", "ERRO LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Iniciar a tela do usuário
                        switch (obj2.Tipo)
                        {
                            case "adm":
                                this.Hide();
                                Form4 telaAdm = new Form4(obj2);
                                telaAdm.ShowDialog();
                                this.Close();
                                break;

                            case "funcionario":
                                this.Hide();
                                Form4 telaFun = new Form4(obj2);
                                telaFun.ShowDialog();
                                this.Close();
                                break;

                            case "cliente":
                                this.Hide();
                                Form4 telaCliente = new Form4(obj2);
                                telaCliente.ShowDialog();
                                this.Close();
                                break;
                            default:
                                MessageBox.Show("Contate o suporte", "ERRO LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas", "ERRO LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void voltar_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja Voltar ?", "Retornar a HOME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form3 home = new Form3();
                home.ShowDialog();
                this.Close();
            }
        }

        private void cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 home = new Form2();
            home.ShowDialog();
            this.Close();
        }
    }
}
