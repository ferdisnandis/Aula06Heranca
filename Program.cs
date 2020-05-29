using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.nome = "Fernanda";
            System.Console.WriteLine( cpf.Saudar() );
            System.Console.WriteLine();

            //digitar CPF
            System.Console.WriteLine( "Digite seu CPF:");
            cpf.cpf = System.Console.ReadLine();

            //Validação CPF
            System.Console.WriteLine( cpf.confirmacaoCPF() );
            System.Console.WriteLine();

            CNPJ cnpj = new CNPJ();

            
            //digitar CNPJ
            System.Console.WriteLine( "Digite seu CNPJ:");
            cnpj.cnpj = System.Console.ReadLine();

            //Validação CNPJ
            System.Console.WriteLine( cnpj.confirmacaoCNPJ() );

        }
    }
}
