using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForAlgLab;
using System.IO;

namespace AlgoritmLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = new string[] { "* Восстановить граф из файла (рекмендуется)",
            "* Создать случайный граф заданного размера",
            "* Показать матрицу смежности",
            "* Найти все простые циклы в графе"};
            char[] menuSymbols = new char[] { 'q', 'w', 'e', 'r' };
            bool goOut = false;
            WorkingGraph workingGraph = null;

            do
            {
                switch(Subroutines.PrintMenu(menu, menuSymbols))
                {
                    //
                    // * Восстановить граф из файла (рекмендуется)
                    //
                    case 'q':
                        {
                            try
                            {
                                workingGraph = new WorkingGraph(GraphHelper.GetMatrixFromFile("input.dat"));
                                Console.WriteLine("Граф успешно восстановлен");
                                Console.WriteLine("Нажмите что-нибудь...");
                                Console.ReadKey(true);
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("\n" + e.Message);
                                Console.WriteLine("Нажмите что-нибудь...");
                                Console.ReadKey(true);
                                break;
                            }
                            break;
                        }
                    //
                    // * Создать случайный граф заданного размера
                    //
                    case 'w':
                        {
                            Console.WriteLine("Разработчик лентяй!");
                            Console.WriteLine("Нажмите что-нибудь...");
                            Console.ReadKey(true);
                            break;
                        }
                    //
                    // * Показать матрицу смежности
                    //
                    case 'e':
                        {
                            if (workingGraph == null)
                            {
                                Console.WriteLine("\nГраф еще не создан. Нажмите что-нибудь...");
                                Console.ReadKey(true);
                            }
                            else
                            {
                                workingGraph.Print(Console.Out);
                                Console.WriteLine("\nНажмите что-нибудь...");
                            }
                            break;
                        }
                    //
                    // * Найти все простые циклы в графе
                    //
                    case 'r':
                        {
                            if (workingGraph == null)
                            {
                                Console.WriteLine("\nГраф еще не создан.");
                                Console.WriteLine("Нажмите что-нибудь...");
                                Console.ReadKey(true);
                                break;
                            }
                            List<List<int>> cycles;
                            for (int i = 0; i < workingGraph.VertexCount; i++)
                            {
                                cycles = workingGraph.GetCycles(i);
                                Console.WriteLine("\nЦиклы для вершины " + i);
                                if (cycles.Count == 0)
                                {
                                    Console.WriteLine("\tДля данной вершины нет циклов");
                                }
                                else
                                {
                                    for (int j = 0; j < cycles.Count; j++)
                                    {
                                        Console.WriteLine("\tЦикл " + j + ":\t" + cycles[j].ToString());
                                    }
                                }
                            }

                            Console.WriteLine("\nНажмите что-нибудь...");
                            Console.ReadKey(true);
                            break;
                        }
                    //
                    // ESC
                    // 
                    case (char)27:
                        {
                            goOut = true;
                            break;
                        }
                }
            } while (!goOut);

        }
    }
}
