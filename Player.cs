using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    internal class Player
    {
        private Random random = new Random();
        private string _name;
        public int Points;

        public Player(string name, int points)
        {
            _name = name;
            Points = points;
        }

        public void Play(Player opponent)
        {
            var winnerNum = random.Next(1,2);
            if (winnerNum == 1)
            {
                Points++;
                opponent.Points--;
                Console.WriteLine($"{_name} has won, {opponent._name} has lost.");
            }
            else if (winnerNum == 2)
            {
                opponent.Points++;
                Points--;
                Console.WriteLine($"{opponent._name} has won, {_name} has lost.");
            }

        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"{_name} - {Points} points.");
        }
    }
}
