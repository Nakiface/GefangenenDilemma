using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GefangenenDilemma
{
    class Program
    {
        static void Main(string[] args)
        {
            var rounds = 7;
            var crime = Crime.Medium;

            var Game = new GameOneVsOne(rounds, crime);
            Game.Play();
        }
    }
}
