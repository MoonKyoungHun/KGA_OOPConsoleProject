namespace Maze
{
    public class Funtion
    {
        Player player = new Player();

        public Point temp;
        public Point temp1;
        public Point goal;
        public Point fake;
        public Point wall;
        

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
            Console.WriteLine("#");
        }

        public void PrintTemp1(int x, int y)
        {
            temp1.x = x;
            temp1.y = y;
            Console.SetCursorPosition(temp1.x, temp1.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("#");
            Console.ResetColor();
        }

        public void PrintBlink()
        {
            
            if(player.pos.x == temp.x && player.pos.y == temp.y)
            {
                player.pos.x = temp1.x;
                player.pos.y = temp1.y;
            }
            else if(player.pos.x == temp1.x && player.pos.y == temp1.y)
            {
                player.pos.x = temp.x;
                player.pos.y = temp.y;
            }
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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(fake.x, fake.y);
            Console.WriteLine("#");
            Console.ResetColor();
        }

        public void PrintWall(int x, int y)
        {
            wall.x = x;
            wall.y = y;

            Console.SetCursorPosition(wall.x, wall.y);
            Console.WriteLine(" ");
        }
    }
}
