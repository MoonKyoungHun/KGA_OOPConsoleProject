using Maze.Maps;
using System.Data;

namespace Maze
{
    public class Game
    {
        private bool isRunning;

        private Map[] map;
        private Map curMap;
        public Map CurMap {  get { return curMap; } }

        public void Run()
        {
            Start();
            while (isRunning)
            {
                Render();
                Input();
                Update();
            }
        }

        private void Start()
        {
            isRunning = true;

            map = new Map[(int)MapType.Size];
            map[(int)MapType.Title] = new TitleMap(this);
            map[(int)MapType.Level1] = new Level1Map(this);
            //map[(int)MapType.Level2] = new Level2Map(this);
            //map[(int)MapType.Level3] = new Level3Map(this);

            curMap = map[(int)MapType.Title];
            curMap.Enter();
        }

        public void ChangeMap(MapType mapType)
        {
            curMap.Exit();
            curMap = map[(int)mapType];
            curMap.Enter();

        }




        public void End()
        {
            Console.Clear();

            Console.WriteLine(" ==========================");
            Console.WriteLine("||                        ||");
            Console.WriteLine("||     탈출     성공!     ||");
            Console.WriteLine("||                        ||");
            Console.WriteLine(" ==========================");
        }

        private void Render()
        {
            curMap.Render();
        }

        private void Input()
        {
            curMap.Input();
        }

        private void Update()
        {
            curMap.Update();
        }
    }
}
