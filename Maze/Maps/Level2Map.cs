using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Maze.Maps
{
    /*
    public class Level2Map : Map
    {
        private bool[,] map;
        public ConsoleKey inputKey;
        private Point goal;
        private Point player;

        public struct Point()
        {
            public int x;
            public int y;
        }

        public Level2Map(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("=============Level2=============");
            Console.WriteLine();
            Console.WriteLine();
            

        }

        public override void Render()
        {
        }

        static void PrintMap()
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (wall.x == x && wall.y == y)
                    {
                        Console.Write(" ");
                    }
                    else if (map[y, x])
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }

                }
                Console.WriteLine();
            }
        }

        static void PrintGoal()
        {
            Console.SetCursorPosition(x,y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("G");
            Console.ResetColor();
        }

        public override void Input()
        {
            
        }

        public override void Update()
        {

        }

        public override void Exit()
        {
            game.ChangeMap(MapType.Level1);
        }
    
    }
    */
}
