using RouteCityLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteCityForms
{
    public partial class Form1 : Form
    {
        private int[][] nodeNetwork;
        private int[][] nodeCoordinates;
        private List<int[]> listOfDrawnPaths = new List<int[]>();
        private Node nd = new Node();
        private List<int> organizedCoordinates = new List<int>();
        private List<Coordinates> listOfNodeCoordinates = new List<Coordinates>();
        public Form1()
        {
            InitializeComponent();
            nodeNetwork = nd.CreateNodeNetwork();
            nodeCoordinates = SetCoordinates();
            AddColumnsToDataGridView();
            AddRowsToDataGridView();
            AddComboBoxValues();
            pictureBox1.Image = CreateNewBitmap();
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
        private void AddRowsToDataGridView()
        {
            nodeNetworkGridView.RowCount = 10;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    nodeNetworkGridView.Rows[j].Cells[i].Value = nodeNetwork[i][j];
                }
            }

        }
        private static Bitmap CreateNewBitmap()
        {
            Bitmap pathwaysBackground = new Bitmap(500, 250);
            Color backgroundColor = Color.FromArgb(255, 255, 255, 255);
            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 250; j++)
                {
                    pathwaysBackground.SetPixel(i, j, backgroundColor);
                }
            }
            return pathwaysBackground;
        }

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
            coordinatesArray[8] = new int[] { 348, 105 };
            coordinatesArray[9] = new int[] { 450, 125 };
            return coordinatesArray;
        }

        private void PaintCoordinates()
        {
            for (int i = 0; i < 10; i++)
            {

                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    Pen pen = new Pen(Color.Black, 2);
                    Font myFont = new Font("Arial", 12, FontStyle.Bold);
                    g.DrawEllipse(pen, new Rectangle(listOfNodeCoordinates[i].xCoord, listOfNodeCoordinates[i].yCoord, 25, 25));
                    g.DrawString((listOfNodeCoordinates[i].whichNode + 1).ToString(), myFont, Brushes.Black, listOfNodeCoordinates[i].xCoord + 5, listOfNodeCoordinates[i].yCoord + 5);
                    pen.Dispose();
                }
            }
        }

        private void OrganizeCoordinates()
        {
            organizedCoordinates.Add(0);
            listOfNodeCoordinates.Add(new Coordinates(nodeCoordinates[0][0], nodeCoordinates[0][1], 0));
            for (int i = 0; i < 10; i++)
            {
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

        private void DrawPaths()
        {
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
                            listOfDrawnPaths.Add(arrayToAdd);
                            listOfDrawnPaths.Add(reverseArrayToAdd);
                            int startPointIndex = FindIndexOfNode(i);
                            int endPointIndex = FindIndexOfNode(j);
                            int[] closestNodes = GetClosestNodes(listOfNodeCoordinates[startPointIndex], listOfNodeCoordinates[endPointIndex]);
                            int[] middleOfLine = GetMiddleOfLine(listOfNodeCoordinates[startPointIndex].anchors[closestNodes[0]], listOfNodeCoordinates[endPointIndex].anchors[closestNodes[1]]);

                            using (var g = Graphics.FromImage(pictureBox1.Image))
                            {
                                Pen pen = new Pen(Color.FromArgb(255, 4, 173, 208), 3);
                                Font myFont = new Font("Arial", 12, FontStyle.Bold);
                                g.DrawLine(pen, listOfNodeCoordinates[startPointIndex].anchors[closestNodes[0]][0] + 12, listOfNodeCoordinates[startPointIndex].anchors[closestNodes[0]][1] + 12, listOfNodeCoordinates[endPointIndex].anchors[closestNodes[1]][0] + 12, listOfNodeCoordinates[endPointIndex].anchors[closestNodes[1]][1] + 12);
                                g.DrawString(nodeNetwork[i][j].ToString(), myFont, new SolidBrush(Color.Black), middleOfLine[0], middleOfLine[1]);
                                pen.Dispose();
                            }

                        }
                    }
                }
            }
        }

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

        private int[] GetMiddleOfLine(int[] startNode, int[] endNode)
        {
            int[] middlePoint = new int[2];
            middlePoint[0] = ((startNode[0] + endNode[0]) / 2);
            middlePoint[1] = ((startNode[1] + endNode[1]) / 2);
            return middlePoint;
        }

        private int[] GetClosestNodes(Coordinates startPoint, Coordinates endPoint)
        {
            int[] anchorIndex = new int[2];
            double shortestDistance = 1000;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    double xCoordStartAnchor = startPoint.anchors[i][0];
                    double yCoordStartAnchor = startPoint.anchors[i][1];
                    double xCoordEndAnchor = endPoint.anchors[j][0];
                    double yCoordEndAnchor = endPoint.anchors[j][1];
                    double distance = Math.Sqrt(Math.Pow((xCoordEndAnchor - xCoordStartAnchor), 2) + Math.Pow((yCoordEndAnchor - yCoordStartAnchor), 2));
                    if (distance <= shortestDistance)
                    {
                        anchorIndex[0] = i;
                        anchorIndex[1] = j;
                        shortestDistance = distance;
                    }
                }
            }
            return anchorIndex;
        }

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
            ShortestDistance sd = new ShortestDistance();
            int shortestPathWeight = sd.ShortestPath(nodeNetwork, selectStartNodeComboBox.SelectedIndex, selectEndNodeComboBox.SelectedIndex);
            resultText.Text = "The shortest path between \"" + (selectStartNodeComboBox.SelectedIndex + 1) + "\" and \"" + (selectEndNodeComboBox.SelectedIndex + 1) + "\" has a weight of " + shortestPathWeight.ToString() + ".";
        }
    }
}
