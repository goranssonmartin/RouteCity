using RouteCityLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteCityForms
{
    public partial class NodeNetworkWindow : Form
    {
        private int[][] nodeNetwork;
        private int[][] nodeCoordinates;
        private List<int[]> listOfDrawnPaths = new List<int[]>();
        private Node nd = new Node();
        Calculator calc = new Calculator();
        private List<int> organizedCoordinates = new List<int>();
        private List<Coordinates> listOfNodeCoordinates = new List<Coordinates>();
        public NodeNetworkWindow()
        {
            InitializeComponent();
            nodeNetwork = nd.CreateNodeNetwork();
            nodeCoordinates = SetCoordinates();
            AddColumnsToDataGridView();
            nodeNetworkGridView.RowCount = 10;
            AddDataToRowsInDataGridView();
            AddComboBoxValues();
            nodeNetworkDrawing.Image = CreateNewBitmap();
            OrganizeCoordinates();
            DrawPaths();
            PaintCoordinates();
        }

        //adds a column for each node in nodeNetwork to the datagridview
        private void AddColumnsToDataGridView()
        {
            DataGridViewColumn one = new DataGridViewColumn
            {
                HeaderText = "1",
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 30
            };
            nodeNetworkGridView.Columns.Add(one);

            DataGridViewColumn two = new DataGridViewColumn
            {
                HeaderText = "2",
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 30
            };
            nodeNetworkGridView.Columns.Add(two);

            DataGridViewColumn three = new DataGridViewColumn
            {
                HeaderText = "3",
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 30
            };
            nodeNetworkGridView.Columns.Add(three);

            DataGridViewColumn four = new DataGridViewColumn
            {
                HeaderText = "4",
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 30
            };
            nodeNetworkGridView.Columns.Add(four);

            DataGridViewColumn five = new DataGridViewColumn
            {
                HeaderText = "5",
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 30
            };
            nodeNetworkGridView.Columns.Add(five);

            DataGridViewColumn six = new DataGridViewColumn
            {
                HeaderText = "6",
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 30
            };
            nodeNetworkGridView.Columns.Add(six);

            DataGridViewColumn seven = new DataGridViewColumn
            {
                HeaderText = "7",
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 30
            };
            nodeNetworkGridView.Columns.Add(seven);

            DataGridViewColumn eight = new DataGridViewColumn
            {
                HeaderText = "8",
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 30
            };
            nodeNetworkGridView.Columns.Add(eight);

            DataGridViewColumn nine = new DataGridViewColumn
            {
                HeaderText = "9",
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 30
            };
            nodeNetworkGridView.Columns.Add(nine);

            DataGridViewColumn ten = new DataGridViewColumn
            {
                HeaderText = "10",
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 30
            };
            nodeNetworkGridView.Columns.Add(ten);
        }

        //adds all values to the combobox with the available node choices
        private void AddComboBoxValues()
        {
            for (int i = 1; i < 11; i++)
            {
                selectStartNodeComboBox.Items.Add(i);
                selectEndNodeComboBox.Items.Add(i);
            }
            selectStartNodeComboBox.SelectedIndex = 0;
            selectEndNodeComboBox.SelectedIndex = 0;
        }
        //adds rows to the datagridview based of the nodeNetwork array
        private void AddDataToRowsInDataGridView()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    nodeNetworkGridView.Rows[j].Cells[i].Value = nodeNetwork[i][j];
                }
            }

        }
        //Creates the background image used in the picturebox displaying the network of nodes
        private static Bitmap CreateNewBitmap()
        {
            Bitmap nodeNetworkBackground = new Bitmap(500, 250);
            Color backgroundColor = Color.FromArgb(255, 240, 240, 240);
            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 250; j++)
                {
                    nodeNetworkBackground.SetPixel(i, j, backgroundColor);
                }
            }
            return nodeNetworkBackground;
        }
        //Sets all the default coordinates of where the nodes can be drawn, first value in each array is x coordinate, second value is y coordinate
        private static int[][] SetCoordinates()
        {
            int[][] coordinatesArray = new int[10][];
            coordinatesArray[0] = new int[] { 50, 125 };
            coordinatesArray[1] = new int[] { 146, 10 };
            coordinatesArray[2] = new int[] { 146, 220 };
            coordinatesArray[3] = new int[] { 166, 145 };
            coordinatesArray[4] = new int[] { 252, 63 };
            coordinatesArray[5] = new int[] { 252, 187 };
            coordinatesArray[6] = new int[] { 368, 10 };
            coordinatesArray[7] = new int[] { 368, 220 };
            coordinatesArray[8] = new int[] { 425, 180 };
            coordinatesArray[9] = new int[] { 450, 80 };
            return coordinatesArray;
        }

        //paints each node at its given coordinates
        private void PaintCoordinates()
        {
            for (int i = 0; i < 10; i++)
            {

                using (var g = Graphics.FromImage(nodeNetworkDrawing.Image))
                {   //makes the text and lines more defined and less pixely
                    g.InterpolationMode = InterpolationMode.High;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.TextRenderingHint = TextRenderingHint.AntiAlias;
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    //creates a pen and a font
                    Pen pen = new Pen(Color.Black, 3);
                    Font myFont = new Font("Arial", 12, FontStyle.Bold);
                    //draws and ellipse and types the node name inside of it
                    g.DrawEllipse(pen, new Rectangle(listOfNodeCoordinates[i].xCoord, listOfNodeCoordinates[i].yCoord, 25, 25));
                    g.DrawString((listOfNodeCoordinates[i].whichNode + 1).ToString(), myFont, Brushes.Black, listOfNodeCoordinates[i].xCoord + 4, listOfNodeCoordinates[i].yCoord + 5);
                    pen.Dispose();
                }
            }
        }

        //goes through the node network and adds each node that hasn't been assigned x- and y coordinates
        private void OrganizeCoordinates()
        {
            for (int i = 0; i < 10; i++)
            {
                if (!organizedCoordinates.Contains<int>(i))
                {
                    organizedCoordinates.Add(i);
                    listOfNodeCoordinates.Add(new Coordinates(nodeCoordinates[organizedCoordinates.Count - 1][0], nodeCoordinates[organizedCoordinates.Count - 1][1], i));
                }
                for (int j = 0; j < 10; j++)
                {
                    if (!organizedCoordinates.Contains<int>(j) && nodeNetwork[i][j] != 0)
                    {
                        organizedCoordinates.Add(j);
                        listOfNodeCoordinates.Add(new Coordinates(nodeCoordinates[organizedCoordinates.Count - 1][0], nodeCoordinates[organizedCoordinates.Count - 1][1], j));
                    }
                }
            }
        }

        //draws every path between nodes
        private void DrawPaths()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (nodeNetwork[i][j] != 0)
                    {
                        if (!CheckForAlreadyDrawnPath(i, j))
                        {
                            int[] arrayToAdd = new int[] { i, j };
                            int[] reverseArrayToAdd = new int[] { j, i };
                            //add both ways (x->y & y->x) to listOfDrawnPaths to make sure the path is only drawn once
                            listOfDrawnPaths.Add(arrayToAdd);
                            listOfDrawnPaths.Add(reverseArrayToAdd);
                            //get index of start- and endpoint to be used when getting the nodes coordinates
                            int startPointIndex = FindIndexOfNode(i);
                            int endPointIndex = FindIndexOfNode(j);
                            Coordinates startPointCoordinates = listOfNodeCoordinates[startPointIndex];
                            Coordinates endPointCoordinates = listOfNodeCoordinates[endPointIndex];
                            //calculates the shortest draw distance between the start node and end nodes anchor points
                            int[] closestNodes = calc.GetClosestNodes(startPointCoordinates, endPointCoordinates);
                            //calculates the coordinates at the middle of the line between the nodes, used to print the path weight
                            int[] middleOfLine = calc.GetMiddleOfLine(startPointCoordinates.anchors[closestNodes[0]], endPointCoordinates.anchors[closestNodes[1]]);

                            using (var g = Graphics.FromImage(nodeNetworkDrawing.Image))
                            {
                                //makes the text and lines more defined and less pixely
                                g.InterpolationMode = InterpolationMode.High;
                                g.SmoothingMode = SmoothingMode.HighQuality;
                                g.TextRenderingHint = TextRenderingHint.AntiAlias;
                                g.CompositingQuality = CompositingQuality.HighQuality;
                                //creates a new path based on the weight of the node connection
                                GraphicsPath p = new GraphicsPath();
                                p.AddString(nodeNetwork[i][j].ToString(), FontFamily.GenericSansSerif, (int)FontStyle.Bold, 19, new Point(middleOfLine[0], middleOfLine[1]), new StringFormat());
                                //creates a random color and a pen with the random color
                                Color color = Color.FromArgb(255, rnd.Next(0, 175), rnd.Next(0, 175), rnd.Next(0, 175));
                                Pen pen = new Pen(color, 5);
                                //draw the line between the nodes
                                g.DrawLine(pen, startPointCoordinates.anchors[closestNodes[0]][0] + 12, startPointCoordinates.anchors[closestNodes[0]][1] + 12, endPointCoordinates.anchors[closestNodes[1]][0] + 12, endPointCoordinates.anchors[closestNodes[1]][1] + 12);
                                //draw the text path using white color
                                g.DrawPath(new Pen(Color.White, 4), p);
                                //fill the next path with the same color as the line
                                g.FillPath(new SolidBrush(color), p);
                                pen.Dispose();
                            }

                        }
                    }
                }
            }
        }
        //Check whether a path has already been drawn by checking the listOfDrawnPaths list
        private bool CheckForAlreadyDrawnPath(int i, int j)
        {
            foreach (var drawnPath in listOfDrawnPaths)
            {
                if (drawnPath.SequenceEqual(new int[] { i, j }) || drawnPath.SequenceEqual(new int[] { j, i }))
                {
                    return true;
                }
            }
            return false;
        }

        //finds the index of a given node in the listOfNodeCoordinates
        private int FindIndexOfNode(int indexOfLoop)
        {
            int index = -1;
            for (int i = 0; i < listOfNodeCoordinates.Count; i++)
            {
                if (listOfNodeCoordinates[i].whichNode == indexOfLoop)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        //Calculates the path weight of the two given nodes
        private void FindPathButton_Click(object sender, EventArgs e)
        {
            shortestPathText.Text = "Shortest path is: ";
            ShortestDistance sd = new ShortestDistance();
            int sourceNode = selectStartNodeComboBox.SelectedIndex;
            int endNode = selectEndNodeComboBox.SelectedIndex;
            int[][] result = sd.ShortestPath(nodeNetwork, sourceNode,endNode );
            int shortestPathWeight = result[0][0];
            int[] path = result[1];
            if (shortestPathWeight != 0)
            {
                PrintPathWay(endNode, path, endNode);
            }
            else
            {
                shortestPathText.Text = "Shortest path doesn't exist because start and end nodes are the same";
            }
            resultText.Text = "The shortest path between \"" + (sourceNode + 1) + "\" and \"" + (endNode + 1) + "\" has a weight of " + shortestPathWeight.ToString() + ".";
        }

        //Prints the shortest path between two ndoes
        public void PrintPathWay(int currentVertex, int[] nodePaths, int targetNode)
        {
            if (currentVertex == -1)
            {
                return;
            }
            PrintPathWay(nodePaths[currentVertex], nodePaths, targetNode);
            if (currentVertex != targetNode)
            {
                shortestPathText.Text = shortestPathText.Text + (currentVertex + 1) + " -> ";
            }
            else
            {

                shortestPathText.Text = shortestPathText.Text + (currentVertex + 1) + ".";
            }
        }

        //resets the program based on a new network of nodes
        private void CreateNewNetworkButton_Click(object sender, EventArgs e)
        {
            listOfDrawnPaths.Clear();
            organizedCoordinates.Clear();
            listOfNodeCoordinates.Clear();
            selectStartNodeComboBox.SelectedIndex = 0;
            selectEndNodeComboBox.SelectedIndex = 0;
            resultText.Text = "";
            shortestPathText.Text = "";
            nodeNetwork = nd.CreateNodeNetwork();
            AddDataToRowsInDataGridView();
            nodeCoordinates = SetCoordinates();
            nodeNetworkDrawing.Image = CreateNewBitmap();
            OrganizeCoordinates();
            DrawPaths();
            PaintCoordinates();
        }
    }
}
