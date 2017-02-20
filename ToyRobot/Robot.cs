namespace ToyRobot
{
    public class Robot
    {
        public int east = 0;
        public int north = 0;
        public string direction;

        public Robot()
        {
            
        }

        public void Move()
        {
            switch (direction)
            {
                case "east":
                    east += 1;
                    break;
                case "west":
                    east -= 1;
                    break;
                case "north":
                    north += 1;
                    break;
                case "south":
                    north -= 1;
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (direction)
            {
                case "east":
                    direction = "north";
                    break;
                case "west":
                    direction = "south";
                    break;
                case "north":
                    direction = "west";
                    break;
                case "south":
                    direction = "east";
                    break;
            }
        }

        public void TurnRight()
        {
            switch (direction)
            {
                case "east":
                    direction = "south";
                    break;
                case "west":
                    direction = "north";
                    break;
                case "north":
                    direction = "east";
                    break;
                case "south":
                    direction = "west";
                    break;
            }
        }

        public string Report()
        {
            return east + "," + north + "," + direction.ToUpper();
        }
    }
}
