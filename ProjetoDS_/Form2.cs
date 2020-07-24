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

namespace ProjetoDS_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void cadastrar_Click(object sender, EventArgs e)
        {
     
        DTO_Usuario obj = new DTO_Usuario();
            obj.Nome = Nome.Text;
            obj.Email = Email.Text;
            obj.UserName = Nusuario.Text;
            obj.Senha = Senha.Text;
            obj.SenhaC = Csenha.Text;
            obj.CPF = Cpf.Text;
            BLL_Cadastro.ValidarCadastro(obj);
            try
            {
                MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 login = new Form1();
                login.ShowDialog();
                this.Close();
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
        private void Limpar_Click(object sender, EventArgs e)
        {
            Nome.Clear();
            Cpf.Clear();
            Email.Clear();
            Senha.Clear();
            Csenha.Clear();
            Nusuario.Clear();
        }
    }
}
