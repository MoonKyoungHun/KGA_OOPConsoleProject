using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Maze
{
    public class Player
    {
        private int x;
        private int y;

        private int hp = 5;
        public int HP { get { return hp; } }

        public void ShowInfo()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine($"생명 게이지 : {hp}");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.SetCursorPosition(0, 5);
        }

        public void PrintPlayer(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("P");
            Console.ResetColor();
        }


    }
}
