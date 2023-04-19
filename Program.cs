// See https://aka.ms/new-console-template for more information
using System;
using Sistema_UC_12;
using Sistema_UC_12.Classes;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        Endereco end = new Endereco();
        end.logradouro = "Rua Esquina";
        end.numero = 69;
        end.complemento = "ponto de trafico";
        end.enderecoComercial = true;

        PessoaFisica novapf = new PessoaFisica();
        novapf.cpf = "08080808080";
        novapf.endereco = end;
        novapf.nascimento = new DateTime (2006,02,02);
        novapf.nome = "jurema";

        //Console.WriteLine(novapf.endereco.logradouro);
        //Console.WriteLine(novapf.endereco.numero);
       // Console.WriteLine(novapf.endereco.complemento);
       // Console.WriteLine(novapf.endereco.enderecoComercial);
       // Console.WriteLine(novapf.nome);
        //Console.WriteLine(novapf.nascimento);

        //interpolação
        Console.WriteLine($"O endereço de {novapf.nome} é {novapf.endereco.logradouro}, numero {novapf.endereco.numero}");

        //concatenaçãoConsole.WriteLine("O endereco de " +novapf.nome + " é " +novapf.endereco.logradouro + ", " +novapf.endereco.numero);

        bool idadevalidade = novapf.ValidarDataNascimento(novapf.nascimento);
        if(idadevalidade == true){
         Console.WriteLine($"Pode beber Pinga");
        }else{
            Console.WriteLine($"Vai ficar só no réfris");
        }



    }
}


