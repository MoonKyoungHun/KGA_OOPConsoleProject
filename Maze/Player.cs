using Maze.Maps;
using System.Numerics;
using System.Xml.Linq;

namespace Maze
{
    public class Player
    {
        public bool[,] map;
        private ConsoleKey inputKey;
        public Point pos;

        public struct Point()
        {
            public int x;
            public int y;
        }

        public int hp = 5;
        public int HP { get { return hp; } }


        public void ShowInfo(int x)
        {
            Console.SetCursorPosition(0, 16);
            Console.WriteLine($"===============level {x}==================");
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine($"생명 게이지 : {hp}");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.SetCursorPosition(0, 0);
        }

        public void Control()
        {
            inputKey = Console.ReadKey(true).Key;
        }

        public void PrintPlayer(int x, int y)
        {
            pos.x = x;
            pos.y = y;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(pos.x, pos.y);
            Console.WriteLine("P");
            Console.ResetColor();
        }

        public void Move(bool[,] map)
        {
            this.map = map;

            switch (inputKey)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;

                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;

                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    break;

                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    MoveRight();
                    break;

            }
        }


        
        public void MoveUp()
        {
            Point next = new Point() { x = pos.x, y = pos.y - 1 };
            if (map[next.y, next.x])
            {
                pos = next;
            }
        }
        public void MoveDown()
        {
            Point next = new Point() { x = pos.x, y = pos.y + 1 };
            if (map[next.y, next.x])
            {
                pos= next;
            }
        }

        public void MoveLeft()
        {
            Point next = new Point() { x = pos.x - 1, y = pos.y };
            if (map[next.y, next.x])
            {
                pos = next;
            }
        }

        public void MoveRight()
        {
            Point next = new Point() { x = pos.x + 1, y = pos.y };
            if (map[next.y, next.x])
            {
                pos = next;
            }
        }
    }
}
