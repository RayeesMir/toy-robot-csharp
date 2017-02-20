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

        public void RobotMoves(string movement)
        {
            switch (movement)
            {
                case "move":
                    if (Surface.IsValidLocation(Toy.east + 1, Toy.north + 1)
                        && Surface.IsValidLocation(Toy.east - 1, Toy.north - 1))
                    {
                        Toy.Move();
                    }
                    break;
                case "right":
                    Toy.TurnRight();
                    break;
                case "left":
                    Toy.TurnLeft();
                    break;
            }
        }
        
        public string Report()
        {
            return Toy.Report();
        }
    }
}
