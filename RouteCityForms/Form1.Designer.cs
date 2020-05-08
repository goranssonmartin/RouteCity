namespace RouteCityForms
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nodeNetworkGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.nodeNetworkGridView.Location = new System.Drawing.Point(16, 166);
            this.nodeNetworkGridView.Name = "nodeNetworkGridView";
            this.nodeNetworkGridView.ReadOnly = true;
            this.nodeNetworkGridView.Size = new System.Drawing.Size(351, 272);
            this.nodeNetworkGridView.TabIndex = 7;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(9, 100);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(0, 13);
            this.resultText.TabIndex = 8;
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Location = new System.Drawing.Point(16, 147);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(535, 13);
            this.explanationLabel.TabIndex = 9;
            this.explanationLabel.Text = "Every column is a node and each row shows which node it is connected to and what " +
    "weight the connection has";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(374, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 250);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.nodeNetworkGridView);
            this.Controls.Add(this.selectEndNodeComboBox);
            this.Controls.Add(this.selectStartNodeComboBox);
            this.Controls.Add(this.findPathButton);
            this.Controls.Add(this.endNode);
            this.Controls.Add(this.startNode);
            this.Name = "Form1";
            this.Text = "Find the shortest path between two nodes";
            ((System.ComponentModel.ISupportInitialize)(this.nodeNetworkGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

