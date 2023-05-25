using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_UC_12.Classes
{
    public class PessoaFisica : Pessoa
    {
       public string cpf { get; set; } 
       public string rg { get; set; }
       public DateTime nascimento { get; set; }
       public override double pagarImposto (float rendimento){
        if( rendimento <=1500){
            return 0;
        } else if( rendimento > 1500 && rendimento <=5000){
            return rendimento *.03;
        } else {
            return rendimento *.05;
        }
       }

        public bool ValidarDataNascimento(DateTime dataNasc){
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if(anos >= 18){
                return true;
            }else{
                return false;
            }
        }

    }
}