namespace Maze
{
    public class Player
    {

        public int x;
        public int y;

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
            this.x = x;
            this.y = y;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("P");
            Console.ResetColor();
        }


    }
}
