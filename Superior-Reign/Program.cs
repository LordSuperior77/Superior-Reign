using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Superior_Reign
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReignEngine v0 startup");
            
            using (Game game = new Game())
            { 
                game.Run(60.0);

            }
        }
    }
}
