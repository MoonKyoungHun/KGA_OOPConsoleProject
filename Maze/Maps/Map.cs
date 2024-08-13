namespace Maze.Maps
{
    public abstract class Map
    {
        protected Game game;

        public Map(Game game)
        {
            this.game = game;
        }

        public abstract void Enter();
        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Exit();

       
    }
}
