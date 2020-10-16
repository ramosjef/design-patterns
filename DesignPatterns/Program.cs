using System;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Facade;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("#################################################");
                Console.WriteLine("");
                Console.WriteLine("Creational");
                Console.WriteLine("");
                Console.WriteLine("1 - Abstract Factory");
                Console.WriteLine("2 - Factory Method");
                Console.WriteLine("3 - Singleton");
                Console.WriteLine("");
                Console.WriteLine("#################################################");
                Console.WriteLine("");
                Console.WriteLine("Structural");
                Console.WriteLine("");
                Console.WriteLine("4 - Adapter");
                Console.WriteLine("5 - Facade");
                Console.WriteLine("6 - Composite");
                Console.WriteLine("");
                Console.WriteLine("#################################################");
                Console.WriteLine("");
                Console.WriteLine("Behavioral");
                Console.WriteLine("");
                Console.WriteLine("7 - Command");
                Console.WriteLine("8 - Strategy");
                Console.WriteLine("9 - Observer");
                Console.WriteLine("");
                Console.WriteLine("#################################################");
                Console.WriteLine("");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("");

                option = Console.ReadLine();

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;

                switch (option)
                {
                    case "1":
                        ExecucaoAbstractFactory.Executar();
                        break;

                    case "2":
                        ExecucaoFactoryMethod.Executar();
                        break;

                    case "3":
                        Singleton.Executar();
                        break;

                    case "4":
                        ExecucaoAdapter.Executar();
                        break;

                    case "5":
                        ExecucaoFacade.Executar();
                        break;

                    case "6":
                        ExecucaoComposite.Executar();
                        break;

                    case "7":
                        ExecucaoCommand.Executar();
                        break;

                    case "8":
                        ExecucaoStrategy.Executar();
                        break;

                    case "9":
                        ExecucaoObserver.Executar();
                        break;

                    default:
                        Console.WriteLine("Opção indisponível");
                        break;
                }

                if (option != "0")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.WriteLine("");
                    Console.ReadKey();
                }

            } while (option != "0");
        }
    }
}
