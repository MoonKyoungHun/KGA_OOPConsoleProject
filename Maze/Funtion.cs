namespace Maze
{
    public class Funtion
    {
        public Point temp;
        public Point temp1;
        public Point goal;
        public Point fake;
        public Point wall;
        public Point trap;


        public struct Point()
        {
            public int x;
            public int y;
        }

        public void PrintTemp(int x, int y)
        {
            temp.x = x;
            temp.y = y;

            Console.SetCursorPosition(temp.x, temp.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("#");
            Console.ResetColor();
        }

        public void PrintTemp1(int x, int y)
        {
            temp1.x = x;
            temp1.y = y;

            Console.SetCursorPosition(temp1.x, temp1.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("#");
            Console.ResetColor();
        }

        public void PrintGoal(int x, int y)
        {
            goal.x = x;
            goal.y = y;

            Console.SetCursorPosition(goal.x, goal.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("G");
            Console.ResetColor();
        }

        public void PrintFake(int x, int y)
        {
            fake.x = x;
            fake.y = y;

            Console.SetCursorPosition(fake.x, fake.y);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("#");
            Console.ResetColor();
        }

        public void PrintWall(int x, int y)
        {
            wall.x = x;
            wall.y = y;

            Console.SetCursorPosition(wall.x, wall.y);
        }

        public void PrintTrap(int x, int y)
        {
            trap.x = x;
            trap.y = y;
            Console.SetCursorPosition(trap.x, trap.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("#");
            Console.ResetColor();
        }
    }
}
