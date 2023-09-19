namespace design_patterns.Flyweight
{
    public class Point
    {
        private int x;

        private int y;
        private PointIcon icon; 

        //private PointType type;

        //private byte[] icon;

        public Point(int x, int y, PointType type, PointIcon icon)
        {
            this.x = x;                 // 4 bytes
            this.y = y;                // 4 bytes
            this.icon = icon;

            //this.type = type;          // 4 bytes
            //this.icon = icon;          //20 KB
        }
        //Having 10000 points adds up  and will take a lot of memory
        public void Draw()
        {
            Console.WriteLine($"{icon.GetType()} at ({x},{y})");
        }
    }
}
