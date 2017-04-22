using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billentyuzetbetyarok
{
    class Game
    {
        Map map;
        Ships ships;

        public Game()
        {
            map = new Map();
            
            ships = new Ships();
        }

        public void setMapSize(int size)
        {
            map.setSize(size);
        }

        public int getMapSize()
        {
            return map.getSize();
        }

        public bool addShip(int[] pos, int length, bool align)
        {
            if (! map.vanHajo(pos, length, align))
            {
                map.addShip(ships.addShip(new Ship(pos, length, align)));
                return true;
            }

            return false;
        }

        public void drawMap()
        {
            for (int i= 0; i < map.getSize(); i++)
            {
                Console.Write((i + 1) + " ");
                for (int j = 0; j < map.getSize(); j++)
                {
                    if (map.getMap()[i, j] == 0)
                        Console.Write("~");
                    else if (map.getMap()[i, j] == 1)
                        Console.Write("=");
                    else if (map.getMap()[i, j] == 2)
                        Console.Write("o");
                    else if (map.getMap()[i, j] == 3)
                        Console.Write("x");
                }
                Console.WriteLine("");
            }
            Console.Write("  ");
            string abc = "ABCDEFGHIJKLMNOP";
            for (int i = 0; i < map.getSize(); i++)
            {
                Console.Write(abc[i]);
            }
            Console.WriteLine();
        }
    }
}
