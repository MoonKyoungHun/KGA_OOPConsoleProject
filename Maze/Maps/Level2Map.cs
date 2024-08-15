using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Maze.Maps
{
    public class Level2Map : Map
    {
        Funtion funtion = new Funtion();
        Player player = new Player();

        public int x;
        public int y;

        private bool[,] map;
        public ConsoleKey inputKey;

        public Level2Map(Game game) : base(game)
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
            player.ShowInfo(2);
            PrintMap();
            funtion.PrintGoal(8, 1);
            funtion.PrintWall(7, 1);
            funtion.PrintFake(6, 4);
            funtion.PrintFake(6, 3);
            player.PrintPlayer(player.pos.x, player.pos.y);
            funtion.PrintTemp(10, 10);
            funtion.PrintTrap(10, 6);
            
        }

        public override void Input()
        {
            player.Control();
        }

        public override void Update()
        {
            player.Move(map);
            Trap();
            CheckGameClear();
            
        }

        public override void Exit()
        {
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

        public void CheckGameClear()
        {

            if (player.pos.x == funtion.goal.x && player.pos.y == funtion.goal.y)
            {
                Console.Clear();
                game.ChangeMap(MapType.Level3);
            }
        }

        public void Trap()
        {
            if (funtion.trap.x == player.pos.x && funtion.trap.y == player.pos.y)
            {
                if(player.HP == 1)
                {
                    game.ChangeMap(MapType.Title);
                }
                player.hp--;

            }
        }
    }
}
