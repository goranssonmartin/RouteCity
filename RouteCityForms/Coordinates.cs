
namespace RouteCityForms
{
    class Coordinates
    {
        public int whichNode;
        public int xCoord;
        public int yCoord;
        public int[][] anchors = new int[4][];

        public Coordinates(int xCoord, int yCoord, int whichNode)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
            this.whichNode = whichNode;
            anchors[0] = new int[] { xCoord-12, yCoord};//left
            anchors[1] = new int[] { xCoord, yCoord+12};//top
            anchors[2] = new int[] { xCoord+12, yCoord};//right
            anchors[3] = new int[] { xCoord, yCoord-12};//bottom
        }
    }
}
