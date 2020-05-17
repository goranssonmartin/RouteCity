
namespace RouteCityForms
{
    class Coordinates
    {
        public int whichNode;
        public int xCoord;
        public int yCoord;
        public int[][] anchorPoints = new int[4][];

        public Coordinates(int xCoord, int yCoord, int whichNode)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
            this.whichNode = whichNode;
            anchorPoints[0] = new int[] { xCoord-12, yCoord};//left
            anchorPoints[1] = new int[] { xCoord, yCoord+12};//top
            anchorPoints[2] = new int[] { xCoord+12, yCoord};//right
            anchorPoints[3] = new int[] { xCoord, yCoord-12};//bottom
        }
    }
}
