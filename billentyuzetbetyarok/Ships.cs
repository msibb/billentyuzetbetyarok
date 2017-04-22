using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billentyuzetbetyarok
{
    class Ship
    {
        public int length;
        public int[] pos = new int[2];
        public bool align;

        public Ship(int[] x_y, int hossz, bool ir){
            length = hossz;
            pos = x_y;
            align = ir;
        } 
    }

    class Ships {
        public List<Ship> ships = new List<Ship>();

        public void addShip(Ship ship){
            ships.Add(ship);
        }

        public bool searchShip(int x, int y){
            foreach (Ship value in ships)
            {
                
            }

            return true;
        }
    }
}
