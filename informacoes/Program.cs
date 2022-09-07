using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Unicode;
using System.Globalization;

class Program
{
    public static void Main(string[] args){
        
        /*3. Faça um programa que leia e valide as seguintes informações:
        a. Nome: maior que 3 caracteres;
        b. Idade: entre 0 e 150;
        c. Salário: maior que zero;
        d. Sexo: 'f' ou 'm';
        e. Estado Civil: 's', 'c', 'v', 'd';*/

        /*a. Nome: maior que 3 caracteres;
        Declaração de variáveis*/
        String nome;

        do
        {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            /*
            Processamento dos dados
            */
            if (nome.Length <= 3)
            {
                Console.WriteLine("Seu nome não pode ser menor de que três caracteres.");
            }else
            {
                Console.WriteLine("Nome válido!");
            }
        } while (nome.Length <= 3);

        /*
        b. Idade: entre 0 e 150;
        Declaração de variáveis*/
        int idade;
        Boolean validar = false;

        do
        {
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            //Processamento dos dados
            if (idade < 0 || idade > 150)
            {   
                validar = false;
                Console.WriteLine("Idade inválida!\nDigite uma idade entre 0 e 150.");
            }else
            {
                validar = true;
                Console.WriteLine($"Sua idade é {idade} anos");
            }
        } while (!validar);

        /*c. Salário: maior que zero;
        Declaração de variáveis*/
        double salario;

        do
        {
            Console.Write("Informe seu salário: R$");
            salario = double.Parse(Console.ReadLine());
            if (salario <= 0)
            {
                Console.WriteLine("Salário tem que ser maior que 0");
            }else
            {
                Console.Write($"Seu salário é R${salario}.");
            }
        } while (salario <= 0);

        /*d. Sexo: 'f' ou 'm';
        Declaração de variáveis*/
        String sexo;
        Boolean valida = false;
        
        do
        {
            /*
            Solicitação de informações ao usuário
            */
            Console.Write("\nForneça informações de seu sexo, sendo \"F\" para o sexo feminino e \"M\" para o sexo masculino: ");
            sexo = Console.ReadLine();
            if (sexo.Equals("f", StringComparison.OrdinalIgnoreCase))
            {
                valida = true;
                Console.WriteLine("O sexo informado é feminino");
            }else if (sexo.Equals("m", StringComparison.OrdinalIgnoreCase))
            {
                valida = true;
                Console.WriteLine("O sexo informado é masculino");
            }else
            {
                valida = false;
                Console.WriteLine("Entrada de dados inválida\nTente novamente.");
            }
        } while (!valida);

        /*e. Estado Civil: 's', 'c', 'v', 'd';
        Declaração de variáveis*/
        bool validacao = false;
        String estadoCivil;
        do
        {
            Console.Write("\nInforme seu estado civil, sendo \"S\" de Solteiro, \"C\" de Casado, \"V\" de Viúvo, \"D\" de Divorciado: ");
            estadoCivil = Console.ReadLine();
            if (estadoCivil.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                validacao = true;
                Console.WriteLine("Seu estado civil é solteiro");
            }else if (estadoCivil.Equals("c", StringComparison.OrdinalIgnoreCase))
            {
                validacao = true;
                Console.WriteLine("Seu estado civil é casado");
            }else if (estadoCivil.Equals("v", StringComparison.OrdinalIgnoreCase))
            {
                validacao = true;
                Console.WriteLine("Seu estado civil é viúvo");
            }else if (estadoCivil.Equals("d", StringComparison.OrdinalIgnoreCase))
            {
                validacao = true;
                Console.WriteLine("Seu estado civil é divorciado");
            }else
            {
                validacao = false;
                Console.WriteLine("Entrada de dados inválida\nTente novamente.");
            }
        } while (!validacao);
    }
}