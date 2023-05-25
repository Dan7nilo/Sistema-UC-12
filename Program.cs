// See https://aka.ms/new-console-template for more information
using System;
using Sistema_UC_12;
using Sistema_UC_12.Classes;

internal class NewBaseType
{

    static void Main(string[] args)
    {
        void BarraCarregamento(string textoCarregamento){

        Console.WriteLine(textoCarregamento);
        Thread.Sleep(500);

        for ( var contador=0; contador < 8; contador++){
        Console.Write("|");
        Thread.Sleep(500);
       }}

       Console.ForegroundColor= ConsoleColor.Cyan;

       Console.WriteLine(@$"
       ----------------------------------------------------------------------------
       -                                                                          -
       - Seja Bem vindo ao nosso Sistema de Cadastro de Pessoa Física e Jurídica  -
       -                                                                          -
       ----------------------------------------------------------------------------
       ");

     BarraCarregamento("Iniciando");

     List<PessoaFisica> ListaPf = new List<PessoaFisica>();
     List<PessoaJuridica> ListaPJ = new List<PessoaJuridica>();

     Console.Clear();
     
     string opcao;
     do{
     Console.WriteLine(@$"
       ----------------------------------------------------------------------------
       -                                                                          -
       -              - Selecione uma das opções para prosseguir -                -
       -                                                                          -
       ----------------------------------------------------------------------------
       -                                                                          -
       -                         1.Pessoa Física                                  -
       -                        2.Pessoa Jurídica                                 -
       -                                                                          - 
       -                             0.Sair                                       -   
       -                                                                          -
       ----------------------------------------------------------------------------
       ");
       opcao = Console.ReadLine();

       switch (opcao)
       {
        case "1":
        string? opcaoPF;
        do{
         Console.Clear();
        Console.WriteLine(@$"
       ----------------------------------------------------------------------------
       -                                                                          -
       -              - Selecione uma das opções para prosseguir -                -
       -                                                                          -
       ----------------------------------------------------------------------------
       -                                                                          -
       -                    1.Cadastrar Pessoa Física                             -
       -                    2.Mostrar Pessoas Físicas                             -
       -                                                                          - 
       -                    0.Voltar a tela anterior                              -   
       -                                                                          -
       ----------------------------------------------------------------------------
       ");
        opcaoPF = Console.ReadLine();

       switch(opcaoPF){
        case "1":
        PessoaFisica novapf = new PessoaFisica();
        Endereco endereco = new Endereco();

        Console.WriteLine("Digite o logradouro da pessoa física que deseja cadastrar: ");
        endereco.logradouro = Console.ReadLine();
        
        Console.WriteLine("Digite o número: ");
        endereco.numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o complemento: ");
        endereco.complemento = Console.ReadLine();

        Console.WriteLine("Esse endereço é comercial? S/N ");
        string endCom = Console.ReadLine().ToUpper();

        if(endCom == "S"){
            endereco.enderecoComercial = true;
        }else{
            endereco.enderecoComercial = false;
        }
        Console.WriteLine("Digite o CPF: ");
        novapf.cpf = Console.ReadLine();

        Console.WriteLine("Digite a data de nascimento: Ex: DD/MM/AAAA ");
        novapf.nascimento = DateTime.Parse(Console.ReadLine());
        bool idadevalidade = novapf.ValidarDataNascimento(novapf.nascimento);
        if(idadevalidade == true){
        Console.WriteLine($"Pode beber Pinga");
        }else{
        Console.WriteLine($"Vai ficar só no réfris");
        }
        Console.WriteLine("Digite o nome da pessoa física que deseja cadastrar: ");
        novapf.nome = Console.ReadLine();
        Thread.Sleep(2000);

        // ListaPf.Add(novapf);
        //StreamWriter sw = new StreamWriter($"{novapf.nome}.txt");
        //sw.WriteLine(novapf.mome);
        //sw.WriteLine(novapf.Nascimento);
        //sw.Close();

        using(StreamWriter sw = new StreamWriter($"{novapf.nome}.txt")){
            sw.WriteLine(novapf.nome);
            sw.WriteLine(novapf.nascimento);
            sw.WriteLine(novapf.cpf);
            sw.WriteLine(novapf.endereco.logradouro);
            sw.WriteLine(novapf.endereco.numero);
            sw.WriteLine(novapf.endereco.complemento);
        }

        Console.WriteLine("Cadastro Efetuado com Sucesso!");
        Thread.Sleep(4000);
            break;

        case "2":
        Console.WriteLine($"Digite o nome da pessoa física que deseje consultar");
        string regitro = Console.ReadLine();
        using(StreamReader sr = new StreamReader("")){
            string linha;
            while ((linha = sr.ReadLine()) != null){
              Console.WriteLine($"{linha}");
            }
        }
        Console.WriteLine("Aperte qualquer tecla para continuar");
        Console.ReadLine();
        // Console.Clear();
        // if (ListaPf.Count >0){
        // foreach (PessoaFisica cadaPessoa in ListaPf){
        // Console.Clear();
        // Console.WriteLine(@$"
        // Nome: {cadaPessoa.nome}
        // Endereço: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero }
        // Data de nascimento: {cadaPessoa.nascimento}
        // ");
        // Console.WriteLine("Digite qualquer tecla para continuar");
        // Console.ReadLine();}
        // }
        // else{ Console.WriteLine("Lista Vazia!!! Digite qualquer tecla para continuar");
        // Console.ReadLine();
        // }
            break;       
        case "0":
            break;
            default:
            Console.Clear();
            Console.WriteLine("Opção Inválida! Digite outra opção");
            Thread.Sleep(2000);
            break;
       }

        }while (opcaoPF != "0");
        
        break;

        case "2":
      
       string? opcaoPJ;

        do{
            Console.Clear();
            Console.WriteLine(@$"
       ----------------------------------------------------------------------------
       -                                                                          -
       -              - Selecione uma das opções para prosseguir -                -
       -                                                                          -
       ----------------------------------------------------------------------------
       -                                                                          -
       -                  1. Cadastrar Pessoa Jurídica                            -
       -                  2. Mostrar Pessoas Jurídicas                            -
       -                                                                          - 
       -                   0. Voltar a tela anterior                              -   
       -                                                                          -
       ----------------------------------------------------------------------------
            ");
             
            opcaoPJ = Console.ReadLine();

            switch(opcaoPJ){
            case "1": 
            PessoaJuridica pj = new PessoaJuridica();
            Endereco endereco = new Endereco();
            
            Console.WriteLine("Digite o nome: ");
            pj.nome = Console.ReadLine();
               
            Console.WriteLine("Digite o logradouro da Empresa que deseja cadastrar: ");
            endereco.logradouro = Console.ReadLine();
        
            Console.WriteLine("Digite o número: ");
            endereco.numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o complemento: ");
           endereco.complemento = Console.ReadLine();

           Console.WriteLine("Afirma que esse endereço seja comercial? S/N ");
           string endCom = Console.ReadLine().ToUpper();

           if(endCom == "S"){
            endereco.enderecoComercial = true;
           }else{
            endereco.enderecoComercial = false;
           }

            Console.WriteLine("Digite o CNPJ da empresa: ");
            pj.cnpj = Console.ReadLine();
            bool ValidarCNPJ(string cnpj){
            if(cnpj.Length >= 14 && (cnpj.Substring(cnpj.Length -4))== "0001" )
            {
                return true;
            } else{
                return false;
            }
        
            Console.WriteLine("Digite a Razão Social: ");
            pj.razaoSocial = Console.ReadLine();  
            };
            ListaPJ.Add(pj);
            
        Console.WriteLine("Cadastro Efetuado com Sucesso!");
        Thread.Sleep(2000);
        break;
        
        case "2":
        Console.Clear();
        if (ListaPJ.Count >0){
        foreach (PessoaJuridica cadaFirma in ListaPJ){
        Console.Clear();
        Console.WriteLine(@$"
        Nome: {cadaFirma.nome}
        Endereço: {cadaFirma.endereco.logradouro}, {cadaFirma.endereco.numero }
        Complemento: {cadaFirma.endereco.complemento}
        CNPJ: {cadaFirma.cnpj}
        ");
        Console.WriteLine("Digite qualquer tecla para continuar");
        Console.ReadLine();}
        }
        else{ Console.WriteLine("Lista Vazia!!! Digite qualquer tecla para continuar");
        Console.ReadLine();
        }
            break; 
        case "0":
        Thread.Sleep(700);
        Console.WriteLine("Obrigado por utilizar nosso Sistema");
        Thread.Sleep(700);
        BarraCarregamento("Finalizando");
        break;
        default:
        Console.Clear();
        Console.WriteLine("Opção inválida, selecione uma das opções acima!");
        Thread.Sleep(2000);
        break;
        }
       
    }while(opcaoPJ !="0");
    break;
    default:
    Console.Clear();
    break;}
    }while (opcao != "0");
    }}


       
     
    


  



    




        //interpolação
        //Console.WriteLine($"O endereço de {novapf.nome} é {novapf.endereco.logradouro}, numero {novapf.endereco.numero}");

        //concatenaçãoConsole.WriteLine("O endereco de " +novapf.nome + " é " +novapf.endereco.logradouro + ", " +novapf.endereco.numero);

        //bool idadevalidade = novapf.ValidarDataNascimento(novapf.nascimento);
        //if(idadevalidade == true){
        //Console.WriteLine($"Pode beber Pinga");
        //}else{
            //Console.WriteLine($"Vai ficar só no réfris");
       // }

        //PessoaJuridica novapj = new PessoaJuridica();
        //novapj.endereco = end;
       // novapj.nome = "master cargas";
        //novapj.cnpj = "00010001000001";
        //novapj.razaoSocial = "Empresa Top";

        //novapj.ValidarCNPJ(novapj.cnpj);

        //if(novapj.ValidarCNPJ(novapj.cnpj)){
            //Console.WriteLine("CNPJ Válido");
        ///}else{
            //Console.WriteLine("CNPJ inválido");
        //}



