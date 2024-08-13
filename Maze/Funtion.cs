namespace Maze
{
    public class Funtion
    {
        private int x;
        private int y;

        public void PrintTemp(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("#");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
        }

        public void PrintGoal(int x, int y)
        {
           
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("G");
            Console.ResetColor();
        }

        public void PrintFake(int x, int y)
        {
            this.x = x;
            this.y = y;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("#");
            Console.ResetColor();
        }

        public void PrintWall(int x, int y)
        {
            this.x = x;
            this.y = y;

            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");
        }
    }
}
