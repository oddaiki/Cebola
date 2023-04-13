using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camadas
{
    public partial class TelaFornecedor : Form
    {
        public TelaFornecedor()
        {
            InitializeComponent();
        }

        Fornecedor forn;
        private void CarregaTabela()
        {
            forn = new Fornecedor();
            dgvDados.DataSource = forn.Pesquisar();
        }
        private void TelaFornecedor_Load(object sender, EventArgs e)
        {
         
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Cnpj = txtCnpj.Text;
            forn.Email = txtEmail.Text;
            forn.Telefone = txtTelefone.Text;
            forn.Razao = txtRazao.Text;
            MessageBox.Show(forn.Gravar() ? "Salvar com sucesso!" :
                "Não foi possível salvar!");
            CarregaTabela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Id=int.Parse(txtId.Text);
            MessageBox.Show(forn.Excluir() ? "Excluído com sucesso!":
                "Não foi possível exlcuir!");
                CarregaTabela();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Id = int.Parse(txtCnpj.Text);
            forn.Cnpj = txtCnpj.Text;
            forn.Email = txtEmail.Text;
            forn.Telefone = txtTelefone.Text;
            forn.Razao = txtRazao.Text;
            MessageBox.Show(forn.Atualizar() ? "Atualizado com sucesso!" :
                "Não foi possível atualizar!");
            CarregaTabela();
        }
    }
}
