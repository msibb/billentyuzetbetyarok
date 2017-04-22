using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billentyuzetbetyarok
{
    class Map
    {
        int size = 8;
        bool[,] map;

        public Map()
        {
            map = new bool[size, size];
        }

        public bool addShip(Ship ship)
        {
            int[] pos = ship.pos;
            int length = ship.length;
            bool align = ship.align;

            if (! align)
            {
                for (int i = pos[0]; i <= pos[0] + length; i++)
                {
                    map[i, pos[1]] = true;
                }
            }
            else
            {
                for (int i = pos[1]; i <= pos[1] + length; i++)
                {
                    map[pos[0], i] = true;
                }
            }

            return true;
        }

        public bool vanHajo(int[] pos, int length, bool align)
        {
            bool van = true;

            if (! align && pos[0] + length <= size)
            {
                for (int i = 0; i <= length; i++)
                {
                    if (! map[pos[0] + i, pos[1]])
                    {
                        van = false;
                    }
                }
            }
            else if(align && pos[0] + length <= size)
            {
                for (int i = 0; i <= length; i++)
                {
                    if (! map[pos[0], pos[1] + i])
                    {
                        van = false;
                    }
                }
            }

            return false;
        }

        public void setSize(int size)
        {
            this.size = size;
        }
    }
}
