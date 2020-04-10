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

        private bool[] visitedVertexes;

        private void InitVisitedVertexes()
        {
            visitedVertexes = new bool[VertexCount];
            for (int i = 0; i < VertexCount; i++)
            {
                visitedVertexes[i] = false;
            }
        }
        public List<List<int>> GetCycles(int vertexNumber)
        {
            if (vertexNumber >= VertexCount || vertexNumber < 0)
            {
                return null;
            }

            cyclesList.Clear();
            currentCycle.Clear();
            InitVisitedVertexes();

            FillCurrentCycleList(vertexNumber, vertexNumber);

            return cyclesList;
        }

        private List<List<int>> cyclesList = new List<List<int>>();
        private List<int> currentCycle = new List<int>();

        private void FillCurrentCycleList(int currentVertex, int vertexNumber)
        {
            currentCycle.Add(currentVertex);
            visitedVertexes[currentVertex] = true;
            for (int i = 0; i < VertexCount; i++)
            {
                //если есть связь
                if (adjacencyMatrix[currentVertex][i] > 0)
                {
                    // если цикл замкнулся и он имеет право на существование
                    if (i == vertexNumber && currentCycle.Count > 2)
                    {
                        currentCycle.Add(i);
                        cyclesList.Add(currentCycle.GetRange(0, currentCycle.Count));
                        currentCycle.RemoveAt(currentCycle.Count - 1);
                    }
                    // если цикл не замкнут, но вершина i еще не была посещена
                    else if (visitedVertexes[i] == false)
                    {
                        FillCurrentCycleList(i, vertexNumber); // идем ее посещать
                    }
                }
            }
            visitedVertexes[currentVertex] = false;
            currentCycle.RemoveAt(currentCycle.Count - 1);
        }

    }
}
