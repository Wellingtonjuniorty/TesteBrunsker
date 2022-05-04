using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConsultaCEP.Controller
{
    internal class BancoDeDados
    {
        MySqlConnection Conexao = new MySqlConnection("Server=localhost; Database=Brunsker; Uid=root; Pwd=Redes@2022");

        internal DataTable ListarImobiliaria()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Imobiliarias", Conexao);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;        
        }
        internal void AdicionarImobiliaria(string NomeProprietario, string NomeImobiliaria)
        {
            AtualizarBancoDeDados(String.Format("INSERT INTO Imobiliarias(nomeProprietario, nomeImobiliaria) VALUES('{0}', '{1}');", NomeProprietario, NomeImobiliaria));
        }
        internal void RemoverImobiliaria(int CodigoImobiliaria)
        {
            AtualizarBancoDeDados(String.Format("DELETE FROM Imobiliarias WHERE CodigoImobiliaria = {0};", CodigoImobiliaria));
        }
        internal void AlterarImobiliaria(string NomeProprietario, string NomeImobiliaria, int CodigoImobiliaria)
        {
            AtualizarBancoDeDados(String.Format("UPDATE Imobiliarias SET nomeProprietario = {0}, nomeImobiliaria = {1} WHERE CodigoImobiliaria = {2};", NomeProprietario, NomeImobiliaria, CodigoImobiliaria));
        }
        internal DataTable ListarImovel()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Imoveis", Conexao);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }
        internal void AdicionarImovel(int CodigoImobiliaria, int Cep, string Logradouro, string Complemento, string Bairro, string Localidade, string Uf, string Disponibilidade)
        {
            AtualizarBancoDeDados(String.Format("INSERT INTO Imoveis (CodigoImobiliaria, cep, logradouro, complemento, bairro, localidade, uf, disponibilidade) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7});", CodigoImobiliaria, Cep, Logradouro, Complemento, Bairro, Localidade, Uf, Disponibilidade));
        }
        internal void RemoverImovel(int CodigoImovel)
        {
            AtualizarBancoDeDados(String.Format("DELETE FROM Imoveis WHERE CodigoImovel = {0}", CodigoImovel));
        }
        internal void AlterarImovel(int CodigoImobiliaria, int Cep,string Logradouro, string Complemento, string Bairro, string Localidade, string Uf, string Disponibilidade, int CodigoImovel)
        {
            AtualizarBancoDeDados(String.Format("UPDATE Imoveis SET CodigoImobiliaria = {0}, cep = {1}, logradouro = {2}, complemento = {3}, bairro = {4}, localidade = {5}, uf = {6}, disponibilidade = {7} WHERE CodigoImovel = {8};", CodigoImobiliaria, Cep, Logradouro, Complemento, Bairro, Localidade, Uf, Disponibilidade, CodigoImovel));
        }
        internal void AtualizarBancoDeDados(string ComandoSQL)
        {
            Conexao.Open();
            MySqlCommand sql = Conexao.CreateCommand();
            sql.CommandText = (ComandoSQL);
            sql.ExecuteNonQuery();
            Conexao.Close();
        }
    }
}
