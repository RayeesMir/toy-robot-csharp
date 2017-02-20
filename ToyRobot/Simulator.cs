namespace ToyRobot
{
    public class Simulator
    {
        public Robot Toy;
        public Table Surface;

        public Simulator(Table table)
        {
            Surface = table;
        }

        public void Place(int east, int north, string direction)
        {
            if (Surface.IsValidLocation(east, north))
            {
                Toy = new Robot
                {
                    direction = direction.ToLower(),
                    east = east,
                    north = north
                };
            }
        }
    }
}
