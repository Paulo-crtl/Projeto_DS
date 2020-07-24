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

namespace ProjetoDS_EAD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(DTO_Usuario obj)
        {
            InitializeComponent();
            txtNome.Text = obj.Nome;
            if(obj.Tipo == "adm")
            {
                txtTipoUsuario.Text = "Administrador";
            }
            if (obj.Tipo == "funcionario")
            {
                txtTipoUsuario.Text = "Funcionário";
            }
            if (obj.Tipo == "cliente")
            {
                txtTipoUsuario.Text = "Cliente";
            }

            TimeSpan tarde = new TimeSpan(12, 0, 0);
            TimeSpan noite = new TimeSpan(18, 0, 0);
            TimeSpan HoraAtual = DateTime.Now.TimeOfDay;
            if (HoraAtual < tarde)
            {
                txtHorarioEntrada.Text = "Bom Dia";
            }
            else if (HoraAtual < noite)
            {
                txtHorarioEntrada.Text = "Boa Tarde";
            }
            else
            {
                txtHorarioEntrada.Text = "Boa noite";
            }
            if (obj.Tipo == "funcionario")
            {
                this.tabControl1.TabPages.Remove(tabPageFuncionarios);
                this.tabControl1.TabPages.Remove(tabPageProdutos);
                this.tabControl1.TabPages.Remove(tabPageRelatorios);
                btnInserirRecado.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }

        private void btnInserirRecado_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try { 
            DTO_Produto obj = new DTO_Produto();
            obj.CodBarras = Cod.Text;
            obj.Nome = Produto.Text;
            obj.Preço = Preco.Text;
            obj.Estoque = Estoque.Text;
            obj.Unidade = Unidade.Text;
            obj.Tipo = tipoUnidade.Text;
            obj.Descricao = Desc.Text;
            if(Ativo.Checked == true)
            {
                obj.Ativo = "ativo";
            }
            if(Inativo.Checked == true)
            {
                obj.Ativo = "inativo";
            }
            obj.Acao = "cadastro";
                string mensagem = BLL_Produto.CadProduto(obj);
                MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cod.Clear();
                Produto.Clear();
                Preco.Clear();
                Estoque.Clear();
                Unidade.Clear();
                Desc.Clear();
                tipoUnidade.SelectedIndex = -1;
                Ativo.Checked = false;
                Inativo.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Produto obj = new DTO_Produto();
                obj.IdProduto = int.Parse(id.Text);
                obj.CodBarras = CodA.Text;
                obj.Nome = ProdutoA.Text;
                obj.Preço = PrecoA.Text;
                obj.Estoque = EstoqueA.Text;
                obj.Unidade = UnidadeA.Text;
                obj.Tipo = tipoA.Text;
                obj.Descricao = DescAlterar.Text;
                if (AtivoA.Checked == true)
                {
                    obj.Ativo = "ativo";
                }
                if (InativoA.Checked == true)
                {
                    obj.Ativo = "inativo";
                }
                obj.Acao = "alteracao";
                string mensagem = BLL_Produto.CadProduto(obj);
                MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CodA.Clear();
                ProdutoA.Clear();
                PrecoA.Clear();
                EstoqueA.Clear();
                UnidadeA.Clear();
                DescAlterar.Clear();
                tipoA.SelectedIndex = -1;
                AtivoA.Checked = false;
                InativoA.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                string codBarras = CodA.Text;
                DTO_Produto obj = new DTO_Produto();
                obj = BLL_Produto.BuscarProduto(codBarras);
                id.Text = obj.IdProduto.ToString();
                CodA.Text = obj.CodBarras;
                ProdutoA.Text = obj.Nome;
                DescAlterar.Text = obj.Descricao;
                PrecoA.Text = obj.Preço;
                tipoA.Text = obj.Tipo;                
                EstoqueA.Text = obj.Estoque;
                UnidadeA.Text = obj.Unidade;
                if (obj.Ativo.ToLower() == "ativo")
                {
                    AtivoA.Checked = true;
                }
                if (obj.Ativo.ToLower() == "inativo")
                {
                    InativoA.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {
            id.Clear();
            Cod.Clear();
            Produto.Clear();
            Preco.Clear();
            Estoque.Clear();
            Unidade.Clear();
            Desc.Clear();
            tipoUnidade.SelectedIndex = -1;
            Ativo.Checked = false;
            Inativo.Checked = false;
        }
    }
}
