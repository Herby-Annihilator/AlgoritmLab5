using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibraryForAlgLab;

namespace AlgoritmLab5
{
    public class WorkingGraph : Graph<int>
    {
        public override void Print(TextWriter writer)
        {
            for (int i = 0; i < VertexCount; i++)
            {
                for (int j = 0; j < VertexCount; j++)
                {
                    writer.Write(adjacencyMatrix[i][j] + ", ");
                }
                writer.WriteLine();
            }
        }
        /// <summary>
        /// Создаст граф на основе заданной матрицы смежности
        /// </summary>
        /// <param name="matrix"></param>
        public WorkingGraph(int[][] matrix)
        {
            AdjacencyMatrix = matrix;
        }
        /// <summary>
        /// Возвращает список циклов (цикл представлен как список из вершин) для данной конкретной вершины.
        /// </summary>
        /// <param name="vertexNumber">Вершина, для которой нужно найти циклы</param>
        /// <returns></returns>
        public List<List<int>> GetCycles(int vertexNumber)
        {
            if (vertexNumber >= VertexCount || vertexNumber < 0)
            {
                return null;
            }

            List<List<int>> toReturn = new List<List<int>>();


        }

    }
}
