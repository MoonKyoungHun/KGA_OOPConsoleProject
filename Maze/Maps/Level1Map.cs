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
            funtion.goal.x = 0;
            funtion.goal.y = 0;
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
                { false,  true, false, false, false,  true,  true,  true,  true, true,  true, false},
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
            funtion.PrintTemp(10, 10);
            funtion.PrintTemp1(10, 6);
            funtion.PrintBlink();

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
            game.End();
        }

        public override void Exit()
        {
            CheckGameClear();
        }

       
        public void CheckGameClear()
        {

            if (player.pos.x == funtion.goal.x && player.pos.y == funtion.goal.y)
            {
                Console.Clear();
                //game.changemap(maptype.level2);
                
            }
            

        }

    }
}
