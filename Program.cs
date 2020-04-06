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

                            break;
                        }
                    //
                    // * Создать случайный граф заданного размера
                    //
                    case 'w':
                        {

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
