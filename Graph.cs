using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgoritmLab5
{
    /// <summary>
    /// От этого класса следует наследовать все остальные графы, добавлять какие угодно методы и поля, но основа должна быть одна.
    /// Т - тип матрицы смежности и других структур.
    /// Это абстрактный класс.
    /// </summary>
    public abstract class Graph<T>
    {
        /// <summary>
        /// Матрица смежности
        /// </summary>
        protected T[][] adjacencyMatrix;
        /// <summary>
        /// Возвращает текущую матрицу смежности графа
        /// </summary>
        public virtual T[][] AdjacencyMatrix
        {
            get
            {
                return adjacencyMatrix;
            }
            protected set
            {
                if (value != null)
                {
                    adjacencyMatrix = value;
                }
                else
                {
                    adjacencyMatrix = new T[1][];
                    adjacencyMatrix[0] = new T[1];
                }
            }
        }
        /// <summary>
        /// Выводит матрицу смежноси в зависимости от ее типа в нужный поток (файл или консоль)
        /// </summary>
        /// <param name="writer"></param>
        public abstract void Print(TextWriter writer);
        /// <summary>
        /// Возвращает число вершин графа
        /// </summary>
        public virtual int VertexCount { get { if (adjacencyMatrix == null) return 0; else return adjacencyMatrix.GetLength(0); } }
    }
}
