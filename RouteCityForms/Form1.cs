using RouteCityLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteCityForms
{
    public partial class Form1 : Form
    {
        private int[][] nodeNetwork;
        private Node nd = new Node();
        public Form1()
        {
            InitializeComponent();
            nodeNetwork = nd.CreateNodeNetwork();
            AddColumnsToDataGridView();
            AddRowsToDataGridView();
            AddComboBoxValues();
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

        //Calculates the path weight of the two given nodes
        private void FindPathButton_Click(object sender, EventArgs e)
        {
            ShortestDistance sd = new ShortestDistance();
            int shortestPathWeight = sd.ShortestPath(nodeNetwork, selectStartNodeComboBox.SelectedIndex, selectEndNodeComboBox.SelectedIndex);
            resultText.Text = "The shortest path between \"" + (selectStartNodeComboBox.SelectedIndex + 1) + "\" and \"" + (selectEndNodeComboBox.SelectedIndex + 1) + "\" has a weight of " + shortestPathWeight.ToString()+".";
        }
    }
}
