namespace RouteCityForms
{
    partial class NodeNetworkWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startNode = new System.Windows.Forms.Label();
            this.endNode = new System.Windows.Forms.Label();
            this.findPathButton = new System.Windows.Forms.Button();
            this.selectStartNodeComboBox = new System.Windows.Forms.ComboBox();
            this.selectEndNodeComboBox = new System.Windows.Forms.ComboBox();
            this.nodeNetworkGridView = new System.Windows.Forms.DataGridView();
            this.resultText = new System.Windows.Forms.Label();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.nodeNetworkDrawing = new System.Windows.Forms.PictureBox();
            this.createNewNetworkButton = new System.Windows.Forms.Button();
            this.shortestPathText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nodeNetworkGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeNetworkDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // startNode
            // 
            this.startNode.AutoSize = true;
            this.startNode.Location = new System.Drawing.Point(13, 30);
            this.startNode.Name = "startNode";
            this.startNode.Size = new System.Drawing.Size(58, 13);
            this.startNode.TabIndex = 2;
            this.startNode.Text = "Start Node";
            // 
            // endNode
            // 
            this.endNode.AutoSize = true;
            this.endNode.Location = new System.Drawing.Point(120, 30);
            this.endNode.Name = "endNode";
            this.endNode.Size = new System.Drawing.Size(55, 13);
            this.endNode.TabIndex = 3;
            this.endNode.Text = "End Node";
            // 
            // findPathButton
            // 
            this.findPathButton.Location = new System.Drawing.Point(219, 46);
            this.findPathButton.Name = "findPathButton";
            this.findPathButton.Size = new System.Drawing.Size(120, 23);
            this.findPathButton.TabIndex = 4;
            this.findPathButton.Text = "Find shortest path";
            this.findPathButton.UseVisualStyleBackColor = true;
            this.findPathButton.Click += new System.EventHandler(this.FindPathButton_Click);
            // 
            // selectStartNodeComboBox
            // 
            this.selectStartNodeComboBox.FormattingEnabled = true;
            this.selectStartNodeComboBox.Location = new System.Drawing.Point(12, 48);
            this.selectStartNodeComboBox.Name = "selectStartNodeComboBox";
            this.selectStartNodeComboBox.Size = new System.Drawing.Size(90, 21);
            this.selectStartNodeComboBox.TabIndex = 5;
            // 
            // selectEndNodeComboBox
            // 
            this.selectEndNodeComboBox.FormattingEnabled = true;
            this.selectEndNodeComboBox.Location = new System.Drawing.Point(123, 48);
            this.selectEndNodeComboBox.Name = "selectEndNodeComboBox";
            this.selectEndNodeComboBox.Size = new System.Drawing.Size(90, 21);
            this.selectEndNodeComboBox.TabIndex = 6;
            // 
            // nodeNetworkGridView
            // 
            this.nodeNetworkGridView.AllowUserToAddRows = false;
            this.nodeNetworkGridView.AllowUserToDeleteRows = false;
            this.nodeNetworkGridView.AllowUserToResizeColumns = false;
            this.nodeNetworkGridView.AllowUserToResizeRows = false;
            this.nodeNetworkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nodeNetworkGridView.Location = new System.Drawing.Point(12, 166);
            this.nodeNetworkGridView.Name = "nodeNetworkGridView";
            this.nodeNetworkGridView.ReadOnly = true;
            this.nodeNetworkGridView.Size = new System.Drawing.Size(351, 272);
            this.nodeNetworkGridView.TabIndex = 7;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("Arial", 12F);
            this.resultText.Location = new System.Drawing.Point(12, 84);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(28, 18);
            this.resultText.TabIndex = 8;
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Location = new System.Drawing.Point(12, 147);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(535, 13);
            this.explanationLabel.TabIndex = 9;
            this.explanationLabel.Text = "Every column is a node and each row shows which node it is connected to and what " +
    "weight the connection has.";
            // 
            // nodeNetworkDrawing
            // 
            this.nodeNetworkDrawing.Location = new System.Drawing.Point(374, 166);
            this.nodeNetworkDrawing.Name = "nodeNetworkDrawing";
            this.nodeNetworkDrawing.Size = new System.Drawing.Size(500, 250);
            this.nodeNetworkDrawing.TabIndex = 10;
            this.nodeNetworkDrawing.TabStop = false;
            // 
            // createNewNetworkButton
            // 
            this.createNewNetworkButton.Location = new System.Drawing.Point(797, 13);
            this.createNewNetworkButton.Name = "createNewNetworkButton";
            this.createNewNetworkButton.Size = new System.Drawing.Size(117, 23);
            this.createNewNetworkButton.TabIndex = 11;
            this.createNewNetworkButton.Text = "Create new network";
            this.createNewNetworkButton.UseVisualStyleBackColor = true;
            this.createNewNetworkButton.Click += new System.EventHandler(this.CreateNewNetworkButton_Click);
            // 
            // shortestPathtext
            // 
            this.shortestPathText.AutoSize = true;
            this.shortestPathText.Font = new System.Drawing.Font("Arial", 12F);
            this.shortestPathText.Location = new System.Drawing.Point(12, 102);
            this.shortestPathText.Name = "shortestPathtext";
            this.shortestPathText.Size = new System.Drawing.Size(26, 18);
            this.shortestPathText.TabIndex = 12;
            // 
            // NodeNetworkWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.shortestPathText);
            this.Controls.Add(this.createNewNetworkButton);
            this.Controls.Add(this.nodeNetworkDrawing);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.nodeNetworkGridView);
            this.Controls.Add(this.selectEndNodeComboBox);
            this.Controls.Add(this.selectStartNodeComboBox);
            this.Controls.Add(this.findPathButton);
            this.Controls.Add(this.endNode);
            this.Controls.Add(this.startNode);
            this.Name = "NodeNetworkWindow";
            this.Text = "Find the shortest path between two nodes";
            ((System.ComponentModel.ISupportInitialize)(this.nodeNetworkGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeNetworkDrawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startNode;
        private System.Windows.Forms.Label endNode;
        private System.Windows.Forms.Button findPathButton;
        private System.Windows.Forms.ComboBox selectStartNodeComboBox;
        private System.Windows.Forms.ComboBox selectEndNodeComboBox;
        private System.Windows.Forms.DataGridView nodeNetworkGridView;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.PictureBox nodeNetworkDrawing;
        private System.Windows.Forms.Button createNewNetworkButton;
        private System.Windows.Forms.Label shortestPathText;
    }
}

