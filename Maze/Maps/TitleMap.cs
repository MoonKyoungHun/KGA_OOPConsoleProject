using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maze.Maps;

namespace Maze.Maps
{
    public class TitleMap : Map
    {
        

        public TitleMap(Game game) : base(game)
        {
        }

        public override void Enter()
        {
        }
        public override void Exit()
        { 
        }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine(" ==========================");
            Console.WriteLine("||                        ||");
            Console.WriteLine("||     랜덤 미로 찾기     ||");
            Console.WriteLine("||                        ||");
            Console.WriteLine(" ==========================");
            Console.WriteLine();
            Console.WriteLine("아무 키 하나 눌러주세요.");
        }

        public override void Input()
        {
            Console.ReadKey();
        }

        public override void Update()
        {
            game.ChangeMap(MapType.Level1);
        }
    }
}
