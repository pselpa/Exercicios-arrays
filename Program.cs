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
                    System.Console.WriteLine("1. Leia dois arrays A e B com 15 elementos. Criai um array C, onde cada elemento de C é a subtração do elemento de A com B");
                    int counter = 0;
                    var listA = new int[15];
                    var listB = new int[15];
                    var listC = new int[15];
 
                    while (counter <= 14) 
                    {
                        Console.Write($"Digite o {counter+1}º número da lista A: ");
                        listA[counter] = Int32.Parse(Console.ReadLine());
                        Console.Write($"Digite o {counter+1}º número da lista B: ");
                        listB[counter] = Int32.Parse(Console.ReadLine());
                        listC[counter] = listA[counter] - listB[counter];
                        counter++;
                    }
                  
                    Console.Write("\nLista A = ");
                    foreach(var item in listA)
                    {
                        Console.Write($"{item.ToString()} ");
                    }
                    
                    Console.Write("\nLista B = ");
                    foreach(var item in listB)
                    {
                        Console.Write($"{item.ToString()} ");
                    }                   
                    
                    Console.Write("\nLista C = ");
                    foreach(var item in listC)
                    {
                        Console.Write($"{item.ToString()} ");
                    }
                    System.Console.WriteLine("\n");
                }


                static void exercicio2()
                {
                    System.Console.WriteLine("2. Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos");
                    int counter = 0;
                    var list = new int[10];
        
                    while (counter <= 9) 
                    {
                        Console.Write($"Digite o {counter+1}º número: ");
                        list[counter] = Int32.Parse(Console.ReadLine());
                        counter++;
                    }

                    int[] orderedList = list.OrderBy(i => i).ToArray();
                    Console.WriteLine("\nOs numeros em ordem crescente são:");
                    foreach (int termo in orderedList) 
                    {
                        Console.WriteLine(termo);
                    }

                    int[] reverseList = list.OrderByDescending(i => i).ToArray();
                    Console.WriteLine("\nOs numeros em ordem decrescente são:");
                    foreach (int termo in reverseList) 
                    {
                        Console.WriteLine(termo);
                    }
                }


                static void exercicio3()
                {
                    System.Console.WriteLine("3. Leia 10 elementos e armazene em um array A. Em seguida, peça um número qualquer e pesquise no array se ele existe. Caso, seja verdade imprima a mensagem: “O número existe no array” , caso contrário “Número inexistente”.");
                    int counter = 0;
                    var list = new int[10];
                            
                    while (counter <= 9) 
                    {
                        Console.Write($"Digite o {counter+1}º número: ");
                        list[counter] = Int32.Parse(Console.ReadLine());
                        counter++;
                    }

                    Console.Write("Insira um número a ser pesquisado: ");
                    int searchNumber = Int32.Parse(Console.ReadLine());
                    bool searchResult = false;

                    foreach (int termo in list)
                    {
                        if (termo == searchNumber)
                        {
                            searchResult = true;
                            break;
                        }
                        else
                        {
                            searchResult = false;
                        }
                    }

                    if (searchResult == true)
                    {
                        System.Console.WriteLine($"{searchNumber} se encontra na lista!");
                    }
                    else
                    {
                        System.Console.WriteLine($"{searchNumber} NÃO se encontra na lista!");
                    }
                }


                static void exercicio4()
                {
                    System.Console.WriteLine("4. Leia dois arrays A e B com 10 elementos.  Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.");
                    int counter = 0;
                    var listA = new int[10];
                    var listB = new int[10];
                    var listC = new int[10];
 
                    while (counter <= 9) 
                    {
                        Console.Write($"Digite o {counter+1}º número da lista A: ");
                        listA[counter] = Int32.Parse(Console.ReadLine());

                        counter++;
                    }
                  
                    Console.Write("\nLista A = ");
                    foreach(var item in listA)
                    {
                        Console.Write($"{item.ToString()} ");
                    }
                    
                    Console.Write("\nLista B = ");
                    foreach(var item in listB)
                    {
                        Console.Write($"{item.ToString()} ");
                    }

                    bool compareAB = true;
                    foreach(var item in listC)
                    {
                        if (item == 0)
                        {
                            compareAB = true;
                        }
                        else
                        {
                            compareAB = false;
                            break;
                        }
                    }

                    if (compareAB == true)
                    {
                        System.Console.WriteLine("\nLISTAS SÃO IGUAIS");
                    }
                    else
                    {
                        System.Console.WriteLine("\nLISTAS SÃO DIFERENTES");
                    }
                }


                static void exercicio5()
                {
                    System.Console.WriteLine("Leia um array A com 15 elementos, e calcule a média aritmética, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.");
                    int counter = 0;
                    var list = new double[15];
                    var number = 0.0;
                    double sum = 0;
                    int onAverage = 0;
                    int aboveAverage = 0;
                    int underAverage = 0;

                    while (counter <= 14)
                    {
                        Console.Write($"Digite o {counter+1}º número da lista: ");
                        number = double.Parse(Console.ReadLine());
                        list[counter] = number;
                        sum += number;
                        counter++;
                    }
                    double average = sum/counter;

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
                        else if (item < average)
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
                    int counter = 0;
                    var listA = new int[12];
                    var listB = new int[12];
                    var listC = new int[12];
 
                    while (counter <= 11)
                    {
                        Console.Write($"Digite o {counter+1}º número da lista A: ");
                        listA[counter] = Int32.Parse(Console.ReadLine());
                        Console.Write($"Digite o {counter+1}º número da lista B: ");
                        listB[counter] = Int32.Parse(Console.ReadLine());
                        counter++;
                    }

                    int[] orderedListA = listA.OrderBy(i => i).ToArray();
                    int[] orderedListB = listB.OrderByDescending(i => i).ToArray();                  

                    int counterC = 0;
                    while (counterC <= 11)
                    {
                        listC[counterC] = orderedListA[counterC] + orderedListB[counterC];
                        counterC++;
                    }
                    int[] orderedListC = listC.OrderBy(i => i).ToArray();

                    Console.Write("Lista A: ");
                    foreach (var item in orderedListA)
                    {
                        Console.Write($"{item}, ");
                    }
                    System.Console.WriteLine("");
                    
                    Console.Write("Lista B: ");
                    foreach (var item in orderedListB)
                    {
                        Console.Write($"{item}, ");
                    }
                    System.Console.WriteLine("");

                    Console.Write("Lista C: ");
                    foreach (var item in orderedListC)
                    {
                        Console.Write($"{item}, ");
                    }
                    System.Console.WriteLine("");
                }
            }
            System.Console.WriteLine("APLICAÇÃO ENCERRADA.");     
        }
    }
}
