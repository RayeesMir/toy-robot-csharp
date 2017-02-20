namespace ToyRobot
{
    public class Table
    {
        public int width;
        public int length;
        public bool IsValidLocation(int east, int north) => east >= 0 && east < width && north >= 0 && north < length;

        public Table(int width, int length)
        {
            this.width = width;
            this.length = length;
        }
    }
}
