using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class PessoaEvento
    {
        public int Idade { get; set; }
        public bool Autorizacao { get; set;}

        public string VerificarAutorizacao(int Idade, bool Autorizacao)
        {
            if(Idade >= 18 || Autorizacao){
                return "Entrada Autorizada!";
            }
            return "Entrada Não Autorizada!";
        }
    }
}