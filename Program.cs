using System;
using System.Linq;

namespace Exercicios_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // MENU PRINCIPAL DOS EXERCÍCIOS
            var mainOption = "";
                       
            while (mainOption != "0")
            {
                System.Console.WriteLine("*** MENU PRINCIPAL ***");
                System.Console.WriteLine("Digite um número de 1 a 6 para escolher o exercício. Digite 0 para sair.");
                mainOption = System.Console.ReadLine();
                
                if (mainOption == "1")
                {
                    System.Console.WriteLine("Selecionado o exercício 1\n");
                    exercicio1();
                }
                
                else if (mainOption == "2")
                {
                    System.Console.WriteLine("Selecionado o exercício 2\n");
                    exercicio2();
                }

                else if (mainOption == "3")
                {
                    System.Console.WriteLine("Selecionado o exercício 3\n");
                    exercicio3();
                }

                else if (mainOption == "4")
                {
                    System.Console.WriteLine("Selecionado o exercício 4\n");
                    exercicio4();
                }

                else if (mainOption == "5")
                {
                    System.Console.WriteLine("Selecionado o exercício 5\n");
                    exercicio5();
                }

                else if (mainOption == "6")
                {
                    System.Console.WriteLine("Selecionado o exercício 6\n");
                    exercicio6();
                }


                static void exercicio1()
                {
                    System.Console.WriteLine("1. Leia dois arrays A e B com 15 elementos. Criar um array C, onde cada elemento de C é a subtração do elemento de A com B");
                    var listA = new int[15];
                    var listB = new int[15];
                    var listC = new int[15];
 
                    for (int i = 0; i < 15; i++) 
                    {
                        try
                        {
                            Console.Write($"Digite o {i+1}º número da lista A: ");
                            listA[i] = Int32.Parse(Console.ReadLine());
                            Console.Write($"Digite o {i+1}º número da lista B: ");
                            listB[i] = Int32.Parse(Console.ReadLine());
                            listC[i] = listA[i] - listB[i];
                        }
                        catch (System.Exception)
                        {
                            System.Console.WriteLine("Erro. Um item inválido foi inserido. Insira apenas números inteiros.");
                            i--;
                        }
                    }                  
                    
                    Console.Write("\nLista C = ");
                    foreach(var item in listC)
                    {
                        Console.Write($"{item}  ");
                    }
                    System.Console.WriteLine("\n");
                }



                static void exercicio2()
                {
                    System.Console.WriteLine("2. Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos");
                    var list = new int[10];
        
                    for (int i = 0; i < 10; i++) 
                    {
                        try
                        {
                            Console.Write($"Digite o {i+1}º número: ");
                            list[i] = Int32.Parse(Console.ReadLine());
                        }
                        catch (System.Exception)
                        {
                            System.Console.WriteLine("Erro. Um item inválido foi inserido. Insira apenas números inteiros.");
                            i--;
                        }
                    }

                    Array.Sort(list);
                    Console.WriteLine("\nOs numeros em ordem crescente são:");
                    foreach (int item in list) 
                    {
                        Console.Write($"{item}  ");
                    }
                    System.Console.WriteLine("");

                    Array.Sort(list);
                    Array.Reverse(list);
                    Console.WriteLine("\nOs numeros em ordem decrescente são:");
                    foreach (int item in list) 
                    {
                        Console.Write($"{item}  ");
                    }
                    System.Console.WriteLine("");
                }



                static void exercicio3()
                {
                    System.Console.WriteLine("3. Leia 10 elementos e armazene em um array A. Em seguida, peça um número qualquer e pesquise no array se ele existe. Caso, seja verdade imprima a mensagem: “O número existe no array” , caso contrário “Número inexistente”.");
                    var listA = new int[10];
                    bool searchResult = false;
                    int? searchNumber = null;
                                            
                    for (int i = 0; i < 10; i++) 
                    {
                        try
                        {
                            Console.Write($"Digite o {i+1}º número: ");
                            listA[i] = Int32.Parse(Console.ReadLine());
                        }
                        catch (System.Exception)
                        {
                            System.Console.WriteLine("Erro. Um item inválido foi inserido. Insira apenas números inteiros.");
                            i--;
                        }
                    }

                    Console.Write("\nInsira um número a ser pesquisado: ");
                    while (true)
                    {
                        try
                        {
                            searchNumber = Int32.Parse(Console.ReadLine());
                            break;
                        }
                        catch (System.Exception)
                        {
                            Console.Write("Erro. Um item inválido foi inserido. Insira um número inteiro: ");
                        }
                    }
                    
                    foreach (int termo in listA)
                    {
                        if (termo == searchNumber)
                        {
                            searchResult = true;
                            System.Console.WriteLine($"\n{searchNumber} se encontra na lista!\n");
                            break;
                        }
                        else
                        {
                            searchResult = false;
                        }
                    }

                    if (searchResult == false)
                    {
                        System.Console.WriteLine($"\n{searchNumber} NÃO se encontra na lista!\n");
                    }
                }



                static void exercicio4()
                {
                    System.Console.WriteLine("4. Leia dois arrays A e B com 10 elementos.  Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.");
                    var listA = new int[10];
                    var listB = new int[10];
                    bool areEquals = true;
 
                    for (int i = 0; i < 10; i++) 
                    {
                        try
                        {
                            Console.Write($"Digite o {i+1}º número da lista A: ");
                            listA[i] = Int32.Parse(Console.ReadLine());
                        }
                        catch (System.Exception)
                        {
                            System.Console.WriteLine("Erro. Um item inválido foi inserido. Insira apenas números inteiros.");
                            i--;
                        }
                    }
                    System.Console.WriteLine("");

                    for (int i = 0; i < 10; i++) 
                    {
                        try
                        {
                            Console.Write($"Digite o {i+1}º número da lista B: ");
                            listB[i] = Int32.Parse(Console.ReadLine());
                        }
                        catch (System.Exception)
                        {
                            System.Console.WriteLine("Erro. Um item inválido foi inserido. Insira apenas números inteiros.");
                            i--;
                        }
                    }

                    Array.Sort(listA);
                    Array.Sort(listB);
                    for(int j = 0; j < 10; j++)
                    {
                        if (listA[j] != listB[j])
                        {
                            areEquals = false;
                            break;
                        }
                    }

                    if (areEquals == true)
                    {
                        System.Console.WriteLine("\nLISTAS SÃO IGUAIS\n");
                    }
                    else
                    {
                        System.Console.WriteLine("\nLISTAS SÃO DIFERENTES\n");
                    }
                }


                static void exercicio5()
                {
                    System.Console.WriteLine("Leia um array A com 15 elementos, e calcule a média aritmética, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.");
                    var list = new double[15];
                    var number = 0.0;
                    double sum = 0;
                    int onAverage = 0;
                    int aboveAverage = 0;
                    int underAverage = 0;

                    for (int i = 0; i < 15; i++)
                    {
                        try
                        {
                            Console.Write($"Digite o {i+1}º número da lista: ");
                            number = double.Parse(Console.ReadLine());
                            list[i] = number;
                            sum += number;
                        }
                        catch (System.Exception)
                        {
                            System.Console.WriteLine("Erro. Um item inválido foi inserido. Insira apenas números inteiros.");
                            i--;
                        }
                        
                    }
                    double average = sum/15;

                    foreach (var item in list)
                    {
                        if (item > average)
                        {
                            aboveAverage++;
                        }
                        else if (item == average)
                        {
                            onAverage++;
                        }
                        else
                        {
                            underAverage++;
                        } 
                    }

                    System.Console.WriteLine($"Média = {average}.");
                    System.Console.WriteLine($"Há {onAverage} números na média, {aboveAverage} acima da média e {underAverage} abaixo da média.");
                }



                static void exercicio6()
                {
                    System.Console.WriteLine("6. Leia um array A com 12 elementos. Após sua leitura, colocar os seus elementos em ordem crescente. Depois ler um array B também com doze elementos, colocar os elementos de B em ordem decrescente. Construir um array C, onde cada elemento de C é a soma do elemento correspondente de A com b. Colocar em ordem crescente a matriz C e apresentar os seus valores.");
                    var listA = new int[12];
                    var listB = new int[12];
                    var listC = new int[12];
 
                    for (int i = 0; i < 12; i++)
                    {
                        Console.Write($"Digite o {i+1}º número da lista A: ");
                        listA[i] = Int32.Parse(Console.ReadLine());
                        Console.Write($"Digite o {i+1}º número da lista B: ");
                        listB[i] = Int32.Parse(Console.ReadLine());
                    }

                    Array.Sort(listA);
                    Array.Sort(listB);
                    Array.Reverse(listB);

                    for (int i = 0; i < 12; i++)
                    {
                        listC[i] = listA[i] + listB[i];
                    }
                    Array.Sort(listC);

                    Console.Write("Lista A: ");
                    foreach (var item in listA)
                    {
                        Console.Write($"{item}, ");
                    }
                    System.Console.WriteLine("");
                    
                    Console.Write("Lista B: ");
                    foreach (var item in listB)
                    {
                        Console.Write($"{item}, ");
                    }
                    System.Console.WriteLine("");

                    Console.Write("Lista C: ");
                    foreach (var item in listC)
                    {
                        Console.Write($"{item}, ");
                    }
                    System.Console.WriteLine("");
                }

                System.Console.WriteLine("APLICAÇÃO ENCERRADA.");
            }   
        }
    }
}