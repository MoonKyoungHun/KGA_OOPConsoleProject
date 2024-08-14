namespace Maze
{
    public class Player
    {
        public struct Point()
        {
            public int x;
            public int y;
        }

        public Point pos;

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
            pos.x = x;
            pos.y = y;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(pos.x, pos.y);
            Console.WriteLine("P");
            Console.ResetColor();
        }


    }
}
