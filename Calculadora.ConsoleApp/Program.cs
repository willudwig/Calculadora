using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string nome, res, opM;
            char op, opMemo;
            double v1 = 0.00d;
            double v2 = 0;
            string[] historico = new string[5];
            ushort cont = 0;
            double memo = 0;
         
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("........... Calculadora Top(SQN) 1.0\n");
            Console.Write("Digite seu nome: " );
            nome = Console.ReadLine();
            Console.Clear();
  
            do
            {
                #region região do histórico
                Console.SetCursorPosition(80,4);
                Console.WriteLine("Histórico (últimos 5 resultados):");
                Console.ForegroundColor= ConsoleColor.DarkGray;  
                Console.SetCursorPosition(85, 6);
                Console.WriteLine(historico[0]);
                Console.SetCursorPosition(85, 7);
                Console.WriteLine(historico[1]);
                Console.SetCursorPosition(85, 8);
                Console.WriteLine(historico[2]);
                Console.SetCursorPosition(85, 9);
                Console.WriteLine(historico[3]);
                Console.SetCursorPosition(85, 10);
                Console.WriteLine(historico[4]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                #endregion

                #region região da memória
                Console.SetCursorPosition(80, 16);
                Console.WriteLine(" Memória: " + memo);
                #endregion

                Console.SetCursorPosition(0, 25);
                Console.WriteLine("Seja bem vindo " + nome + ". Por gentileza, nunca altere o tamanho da janela do console.\n\n");
                Console.WriteLine("........... Desenvolvido por: William Ludwig");
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("........... Calculadora Top(SQN) 1.0\n");

                Console.WriteLine("Apenas tecle um número de sua preferência dentre as opções de operações abaixo: \n\n1- Soma \n2- Subtração \n3- Multiplicação \n4- Divisão \n5- Sair\n");
                op = Convert.ToChar(Console.ReadKey().KeyChar);

                if (op == '1')
                {
                    Console.WriteLine(" - SOMAR:");
                    
                }
                else if (op == '2')
                {
                    Console.WriteLine(" - SUBTRAIR:");
                }
                else if (op == '3')
                {
                    Console.WriteLine(" - MULTIPLICAR");
                }
                else if (op == '4')
                {
                    Console.WriteLine(" - DIVIDIR:");
                }

                Console.WriteLine();
                if (op != '5')
                {
                    Console.WriteLine("Digite 'm' para usar o número na memória.\n");
                }
               

                if (op == '1' || op == '2' || op == '3' || op == '4' )
                {
                    Console.Write("Digite o valor 1: ");
                    opM = Console.ReadLine();
                    if (opM == "m")
                    {
                        v1 = memo;
                        Console.WriteLine("Da memória valor 1: " + memo);
                    }
                    else 
                    {
                        v1 = Convert.ToDouble(opM);
                    }
                   
                    Console.Write("Digite o valor 2: ");
                    opM = Console.ReadLine();
                    if (opM == "m")
                    {
                        v2 = memo;
                        Console.WriteLine("Da memória valor 2: " + memo);
                    }
                    else
                    {
                        v2 = Convert.ToDouble(opM);
                    }

                    Console.WriteLine();
                
                    if (op == '1')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        res = v1 + " + " + v2 + " = " + (v1 + v2).ToString("N2") + "\n";
                        Console.WriteLine(res);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        historico[cont] += res;
                        cont++;
                        Console.WriteLine("\nTecle 'S' para guaradar resultado na memória.\nTecle qualquer outra para limpar...");
                        opMemo = Console.ReadKey().KeyChar;
                        if (opMemo == 's')
                        {
                            memo = v1 + v2;
                        }

                        Console.Clear();  
                     }
                    else if (op == '2')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        res = v1 + " - " + v2 + " = " + (v1 - v2).ToString("N2") + "\n";
                        Console.WriteLine(res);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        historico[cont] += res;
                        cont++;
                        Console.WriteLine("\nTecle 'S' para guaradar resultado na memória.\nTecle qualquer outra para limpar...");
                        opMemo = Console.ReadKey().KeyChar; 
                        if (opMemo == 's')
                        {
                            memo = v1 - v2;
                        }

                        Console.Clear();

                    }
                    else if (op == '3')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        res = v1 + " * " + v2 + " = " + (v1 * v2).ToString("N2") + "\n";
                        Console.WriteLine(res);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        historico[cont] += res;
                        cont++;
                        Console.WriteLine("\nTecle 'S' para guaradar resultado na memória.\nTecle qualquer outra para limpar...");
                        opMemo = Console.ReadKey().KeyChar;
                        if (opMemo == 's')
                        {
                            memo = v1 * v2;
                        }
                        Console.Clear();
                     
                    }
                    else if ( op == '4')
                    {
                        double div;
                        if (v2 == 0)
                        {
                            div = v2;
                            Console.WriteLine("Não se pode dividir por zero!");
                        }
                        else
                            div = v1 / v2;
                        Console.ForegroundColor = ConsoleColor.White;
                        res = v1 + " / " + v2 + " = " + div.ToString("N2") + "\n";
                        Console.WriteLine(res);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        historico[cont] += res;
                        cont++;
                        Console.WriteLine("\nTecle 'S' para guaradar resultado na memória.\nTecle qualquer outra para limpar...");
                        opMemo = Console.ReadKey().KeyChar;
                        if (opMemo == 's')
                        {
                            memo = v1 / v2;
                        }

                        Console.Clear();
                    }
                }
                else
                {
                    if (op != '5')
                    {
                        Console.WriteLine("Comando inválido!");
                        Console.Write("\n\nTecle para limpar...");
                        Console.ReadKey();
                        Console.Clear();
                      }
                }
            } while (op != '5');

            Console.WriteLine("\n\nCalculadora Top(SQN) 1.0 foi finalizada!");
            Console.ReadKey();
        }
    }
}
//TAREFA FUTURA:
//guardar o resultado como memória para ser reutilizado em v1 ou v2.
