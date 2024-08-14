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
            player.map = map;
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
            player.PrintPlayer(player.pos.x, player.pos.y);
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
            player.Move(map);
            CheckGameClear();
        }

        public override void Exit()
        {
        }

       
        public void CheckGameClear()
        {

            //if (player1.pos.x == goal.x && player1.pos.y == goal.y)
            //{
            //    Console.Clear();
            //    //game.ChangeMap(MapType.Level2);
            //    game.End();
            //}

        }

    }
}
