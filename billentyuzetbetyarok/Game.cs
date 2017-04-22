using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billentyuzetbetyarok
{
    class Game
    {
        public Game()
        {
            Map map = new Map();

            map.setSize(8);
            Ships ships = new Ships();

            // while
            if (! map.vanHajo([1, 1], 2, true))
            {
                map.addShip(ships.addShip(new Ship([1, 1], 2, true));
            }

            // x, y

            
        }
    }
}
