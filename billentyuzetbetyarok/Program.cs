using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billentyuzetbetyarok
{
    class Program
    {
        static int meret;

        static void Main(string[] args)
        {
            Game game = new billentyuzetbetyarok.Game();

            setSize:
            Console.WriteLine("mekkora legyen a pálya?");
            if (! int.TryParse(Console.ReadLine(), out meret))
            {
                Console.WriteLine("Rossz méret!");
                goto setSize;
            }
            game.setMapSize(meret);

            bool more = true;

            do
            {
                Console.Clear();
                game.drawMap();
                Console.WriteLine("Rakj le egy hajót:");
                int length = 1;
                int[] pos = new int[2];
                bool align = false;

            setLength:
                Console.WriteLine("Add meg a hajó méretét: ");
                if (! int.TryParse(Console.ReadLine(), out length) && length < game.getMapSize())
                {
                    Console.WriteLine("Rossz méret!");
                    goto setLength;
                }

            setPos:
                Console.WriteLine("Add meg a hajó helyét (pl.: A1): ");
                string localPos = Console.ReadLine();
                pos[0] = game.getMapSize();
                string abc = "ABCDEFGHIJKLMNOP";
                for (int i = 0; i < game.getMapSize(); i++)
                {
                    if (abc[i] == localPos[0])
                    {
                        pos[0] = i;
                        break;
                    }
                }
                if (! int.TryParse(localPos[1].ToString(), out pos[1]) || pos[0] == game.getMapSize())
                {
                    Console.WriteLine("Rossz hely!");
                    goto setPos;
                }

            setAlign:
                Console.WriteLine("Add meg a hajó irányát (0 = horizontális, 1 = vertikális): ");
                align = (Console.ReadLine() == "0") ? false : true;

                Console.WriteLine("Szeretnél még több hajót lerakni? (0 = Igen, 1 = Nem)");
                more = (Console.ReadLine() == "0") ? true : false;

                Console.WriteLine(game.addShip(pos, length, align));
                Console.WriteLine(pos[0]); 
                Console.WriteLine(pos[1]);
                Console.WriteLine(length);
                Console.WriteLine(align);
                Console.ReadKey();
            } while (more);

            Console.ReadKey();
        }
    }
}
