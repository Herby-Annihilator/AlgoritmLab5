using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmLab5.AlgoritmLab6
{
    public class Region
    {
        /// <summary>
        /// Идентификатор региона
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Длина района
        /// </summary>
        private int lenght;
        /// <summary>
        /// Возвращает или задает длину района
        /// </summary>
        private int Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value < 1)
                {
                    lenght = 1;
                }
                else
                {
                    lenght = value;
                }
            }
        }
        /// <summary>
        /// Ширина района
        /// </summary>
        private int width;
        /// <summary>
        /// Возвращает или задает ширину района
        /// </summary>
        private int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 1)
                {
                    width = 1;
                }
                else
                {
                    width = value;
                }
            }
        }
        /// <summary>
        /// Дистанция контроля для данного региона
        /// </summary>
        private int controlDistance;
        /// <summary>
        /// Возвращает или задает дистанцию контроля для данного региона
        /// </summary>
        public int ControlDistance
        {
            get
            {
                return controlDistance;
            }
            set
            {
                if (value < 1)
                {
                    controlDistance = 1;
                }
                else
                {
                    controlDistance = value;
                }
            }
        }
        /// <summary>
        /// Список соседей
        /// </summary>
        private List<Region> regions;
        /// <summary>
        /// Возвращает список соседей
        /// </summary>
        public List<Region> Regions
        {
            get
            {
                return regions;
            }
            private set
            {
                if (value == null)
                {
                    regions = new List<Region>();
                }
                else
                {
                    regions = value;
                }
            }
        }

        public Region(int id, int lenght, int width, int controlDistance, List<Region> regions = null)
        {
            ID = id;
            Lenght = lenght;
            Width = width;
            ControlDistance = controlDistance;
            Regions = regions;
        }
    }
}
