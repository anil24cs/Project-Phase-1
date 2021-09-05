using System;
using System.IO;
using System.Collections.Generic;


namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n******************Welcome to Rainbow School*******************\n");
           
        begin:
            //User Interactions at the terminal window
            Console.WriteLine();
            Console.WriteLine("Make your choice :");
            Console.WriteLine("Enter 1 to store teachers data");
            Console.WriteLine("Enter 2 to Retrive teachers data");
            Console.WriteLine("Enter 3 to Update teachers data");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    int size_of_array = 0;

                    FileInfo fi = new FileInfo(@"C:\Users\11036847\source\repos\trying\th\bin\Debug\net5.0data.txt");
                    size_of_array = 1;
                    string[][] dataentry = new string[size_of_array][];
                    using (StreamWriter wrt = fi.AppendText())
                    {

                        do
                        {
                            size_of_array = 1;
                            //declaring the size of columns as consntant
                            //This is jagged array
                            for (int i = 0; i < size_of_array; i++)
                            {
                                dataentry[i] = new string[3];
                            }
                            for (int i = 0; i < size_of_array; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    if (j == 0)
                                    {
                                        //Entering data inside the jagged array
                                        Console.WriteLine("\nEnter Teacher Id");
                                        dataentry[i][j] = Console.ReadLine();
                                    }
                                    if (j == 1)
                                    {
                                        Console.WriteLine("Enter Name of the Teacher");
                                        dataentry[i][j] = Console.ReadLine();
                                    }
                                    if (j == 2)
                                    {
                                        Console.WriteLine("Enter Class and Section");
                                        dataentry[i][j] = Console.ReadLine();
                                    }

                                }
                            }
                            for (int i = 0; i < size_of_array; i++)
                            {
                                //Printing inside the files                               
                                for (int j = 0; j < 3; j++)
                                {
                                    if (j == 0)
                                    {
                                        wrt.Write(dataentry[i][j]);
                                        wrt.Write(",");
                                    }
                                    if (j == 1)
                                    {
                                        wrt.Write(dataentry[i][j], ",");
                                        wrt.Write(",");
                                    }
                                    if (j == 2)
                                    {
                                        wrt.Write(dataentry[i][j], "\n");
                                    }

                                }
                                wrt.WriteLine("");
                            }
                            Console.WriteLine("*******************************************");
                            Console.WriteLine("Enter 1 to continue adding data");
                            Console.WriteLine("Enter 2 to Exit");
                            Console.WriteLine("*********************************************\n");
                            choice = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            size_of_array++;
                            if (choice == 2)
                            {
                                goto begin;
                            }

                        } while (choice == 1);
                    }
                    break;
                case 2:
                    Console.WriteLine();
                    string text = File.ReadAllText(@"C:\Users\11036847\source\repos\trying\th\bin\Debug\net5.0data.txt");
                    Console.WriteLine(text);
                    goto begin;
                    break;

                case 3:

                    Console.WriteLine("\nEnter the Line where you want to update teachers data");
                    int b = int.Parse(Console.ReadLine());
                    int a = b - 1;
                    String filepath = @"C:\Users\11036847\source\repos\trying\th\bin\Debug\net5.0data.txt";
                    string[] lines = File.ReadAllLines(filepath);
                    Console.WriteLine("\nThe current data is going to be updated :");
                    Console.WriteLine(lines[a]);
                    Console.WriteLine("\nEnter the Teacher id,Name of ,Class and Section :");
                    if (lines[a].Contains(lines[a]))
                        lines[a] = Console.ReadLine();
                    //and save it:
                    File.WriteAllLines(filepath, lines);
                    goto begin;
                    break;

                default:
                    Console.WriteLine("\n*********************************************************");
                    Console.WriteLine("Thank you!!");
                    Console.WriteLine("*********************************************************\n");
                    Console.ReadKey();
                    break;

            }
        }
    }
}