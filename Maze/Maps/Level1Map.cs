namespace Maze.Maps
{
    public class Level1Map : Map
    {
        Funtion funtion = new Funtion();
        Player player1 = new Player();


        public int x;
        public int y;


        private bool[,] map;
        public ConsoleKey inputKey;

        public struct Point()
        {
            public int x;
            public int y;
        }

        public Point player;
        public Point goal;
        

        public Level1Map(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            // Map 생성
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine("=============Level1=============");
            Console.WriteLine();
            Console.WriteLine();

            map = new bool[,]
            {
                { false, false, false, false, false, false, false, false, false, false, false, false},
                { false,  true, false, false, false,  true,  true, false,  true,  true,  true, false},
                { false,  true, false, false, false,  true,  true, false,  true,  true,  true, false},
                { false,  true, false, false, false, false,  true, false, false, false,  true, false},
                { false,  true, false, false, false, false,  true, false, false, false,  true, false},
                { false,  true,  true,  true, true,   true,  true,  true,  true, false,  true, false},
                { false,  true, false, false, false,  true,  true,  true,  true, false,  true, false},
                { false,  true, false,  true, false,  true,  true, false, false, false, false, false},
                { false,  true, false,  true,  true,  true,  true, false, false, false, false, false},
                { false,  true, false,  true,  true,  true,  true,  true,  true,  true, false, false},
                { false,  true, false,  true,  true,  true,  true,  true,  true,  true,  true, false},
                { false, false, false, false, false, false, false, false, false, false, false, false},
            };
        }

        public override void Render()
        {
            Console.Clear();

            PrintMap();
            funtion.PrintGoal(8, 1);
            funtion.PrintWall(7, 1);
            funtion.PrintFake(6, 4);
            funtion.PrintFake(6, 3);
            player1.PrintPlayer(1, 1);
        }

        public override void Input()
        {
            inputKey = Console.ReadKey(true).Key;
        }

        public void PrintMap()
        {

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x])
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

        public override void Update()
        {
            Move();
            CheckGameClear();
        }

        public override void Exit()
        {
        }

        public void Move()
        {
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
            player.x = player1.pos.x;
            player.y = player1.pos.y;
            Point next = new Point() { x = player.x, y = player.y - 1 };
            if (map[next.y, next.x])
            {
                player = next;
            }
        }
        public void MoveDown()
        {
            player.x = player1.pos.x;
            player.y = player1.pos.y;
            Point next = new Point() { x = player.x, y = player.y + 1 };
            if (map[next.y, next.x])
            {
                player = next;
            }
        }

        public void MoveLeft()
        {
            Point next = new Point() { x = player.x - 1, y = player.y };
            if (map[next.y, next.x])
            {
                player = next;
            }
        }

        public void MoveRight()
        {
            Point next = new Point() { x = player.x + 1, y = player.y };
            if (map[next.y, next.x])
            {
                player = next;
            }
        }

        public void CheckGameClear()
        {

            if (player.x == goal.x && player.y == goal.y)
            {
                Console.Clear();
                //game.ChangeMap(MapType.Level2);
                game.End();
            }

        }

    }
}
