using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Estudante
    {
        public string? Nome { get; set; }
        public double Nota {get; set; }
        public int presenca { get; set; }

        public string VerificaAprovacao(double Nota, int presenca){
            if(Nota >= 5 && presenca > 30){
                return "Aluno Aprovado";
            }
            return "Estudante Reprovado";
        }

    }
}