using ConsultaCEP.View;
using ConsultaCEP.Controller;
using System.Data;

namespace ConsultaCEP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroImobiliaria cadastroImobiliaria = new CadastroImobiliaria();
            cadastroImobiliaria.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CadastroImobiliaria cadastroImobiliaria = new CadastroImobiliaria();
            cadastroImobiliaria.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Imobiliaria imobiliaria     = new Imobiliaria();
            imobiliaria.NomeProprietario = "Vitor Almeida";
            imobiliaria.NomeImobiliaria = "VA Imoveis";
            imobiliaria.Adicionar(imobiliaria);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            dataGridView1.DataSource = bancoDeDados.ListarImobiliaria();
            dataGridView1.Columns["idImobiliaria"].Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }
        public void AtualizarDados()
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            
            dataGridView1.DataSource = bancoDeDados.ListarImobiliaria();
            dataGridView1.Columns["idImobiliaria"].Visible = false;

            dataGridView2.DataSource = bancoDeDados.ListarImovel();
            dataGridView2.Columns["idImovel"].Visible = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            AtualizarDados();
        }
    }
}