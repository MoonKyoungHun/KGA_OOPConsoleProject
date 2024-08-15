namespace Maze.Maps
{
    public class Level1Map : Map
    {
        Funtion funtion = new Funtion();
        Player player = new Player();

        public int x;
        public int y;

        private bool[,] map;
        public ConsoleKey inputKey;

        public Level1Map(Game game) : base(game)
        {
            player.pos.x = 1;
            player.pos.y = 1;
        }

        
        public override void Enter()
        {
            Console.CursorVisible = false;

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
            player.ShowInfo(1);
            PrintMap();
            funtion.PrintGoal(8, 1);
            funtion.PrintWall(7, 1);
            funtion.PrintFake(6, 4);
            funtion.PrintFake(6, 3);
            player.PrintPlayer(player.pos.x, player.pos.y);
            funtion.PrintTemp(10, 10);
            funtion.PrintTemp1(10, 6);
        }

        public override void Input()
        {
            player.Control();
        }

        public void PrintMap()
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (funtion.wall.x == x && funtion.wall.y == y)
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

        public override void Update()
        {
            player.Move(map);
            PrintBlink();
            CheckGameClear();
        }

        public override void Exit()
        {
        }

        public void PrintBlink()
        {

            if (player.pos.x == funtion.temp.x && player.pos.y == funtion.temp.y)
            {
                player.pos.x = funtion.temp1.x;
                player.pos.y = funtion.temp1.y;
            }
            else if (player.pos.x == funtion.temp1.x && player.pos.y == funtion.temp1.y)
            {
                player.pos.x = funtion.temp.x;
                player.pos.y = funtion.temp.y;
            }
        }

        public void CheckGameClear()
        {

            if (player.pos.x == funtion.goal.x && player.pos.y == funtion.goal.y)
            {
                Console.Clear();
                game.ChangeMap(MapType.Level2);
            }
        }

    }
}
