using psc_lista_02_2025.Models;
using System;

Lista lista = new Lista();
bool loop = true;

while (loop != false)
{
    Console.WriteLine("MENU - Exercícios de 1 a 5 da Lista 02 - 2025");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Exercício 1");
    Console.WriteLine("2. Exercício 2");
    Console.WriteLine("3. Exercício 3");
    Console.WriteLine("4. Exercício 4");
    Console.WriteLine("5. Exercício 5");
    Console.WriteLine("0. Sair");
    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            lista.Exercicio1();
            break;
        case "2":
            lista.Exercicio2();
            break;
        case "3":
            lista.Exercicio3();
            break;
        case "4":
            lista.Exercicio4();
            break;
        case "5":
            lista.Exercicio5();
            break;
        case "0":
            loop = false;
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

Console.WriteLine("Programa encerrado.");
