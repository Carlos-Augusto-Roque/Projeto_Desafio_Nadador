using System;

namespace Projeto_Desafio_Nadador
{
    class Program
    {
        static void Main(string[] args)
        {

            //variáveis
            float idade;

            //entrada de dados
            Console.Write("Digite a idade do nadador: ");
            idade = float.Parse(Console.ReadLine());

            //processamento

            if(idade>=5 && idade<=7){ 
                Console.WriteLine("O nadador é da categoria Infantil A");}
            if(idade>=8 && idade<=10){ 
                Console.WriteLine("O nadador é da categoria Infantil B");}
            if(idade>=11 && idade<=13){ 
                Console.WriteLine("O nadador é da categoria Juvenil A");}
            if(idade>=14 && idade<=17){ 
            Console.WriteLine("O nadador é da categoria Juvenil B");}
             if(idade>18){ 
            Console.WriteLine("O nadador é da categoria Sênior");}
            
            
           

        }
    }
}
