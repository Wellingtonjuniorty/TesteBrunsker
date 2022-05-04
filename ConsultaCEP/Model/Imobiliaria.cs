using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultaCEP.Controller;

namespace ConsultaCEP
{
    public class Imobiliaria
    {
        public int CodigoImobiliaria { get; set; }
        public string NomeProprietario   { get; set; }
        public string NomeImobiliaria { get; set; }

        public void Listar()
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.ListarImobiliaria();
        }
        public void Adicionar(Imobiliaria imobiliaria)
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.AdicionarImobiliaria(imobiliaria.NomeProprietario, imobiliaria.NomeImobiliaria);
        }
        public void Remover(Imobiliaria imobiliaria)
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.RemoverImobiliaria(imobiliaria.CodigoImobiliaria);
        }
        public void Alterar(Imobiliaria imobiliaria)
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.RemoverImobiliaria(imobiliaria.CodigoImobiliaria);
        }
    }
}
