using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultaCEP.Controller;

namespace ConsultaCEP
{
    public class Imovel
    {
        public int CodigoImovel { get; set; }
        public int CodigoImobiliaria { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento   { get; set; }   
        public string Bairro { get; set; }
        public string Localidade { get; set; }  
        public string UF { get; set; }  
        public string Disponibilidade { get; set; }

        public void Listar()
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.ListarImovel();
        }
        public void Adicionar(Imovel imovel)
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.AdicionarImovel(imovel.CodigoImobiliaria, imovel.Cep, imovel.Logradouro, imovel.Complemento, imovel.Bairro, imovel.Localidade, imovel.UF, imovel.Disponibilidade);
        }
        public void Remover(Imovel imovel)
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.RemoverImovel(imovel.CodigoImovel);
        }
        public void Alterar(Imovel imovel)
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.AlterarImovel(imovel.CodigoImobiliaria, imovel.Cep, imovel.Logradouro, imovel.Complemento, imovel.Bairro, imovel.Localidade, imovel.UF, imovel.Disponibilidade, imovel.CodigoImovel);
        } 
    }
}
