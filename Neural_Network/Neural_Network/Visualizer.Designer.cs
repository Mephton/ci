namespace Neural_Network
{
    partial class Visualizer
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showNetworkOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trainOutputLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.trainHiddenLayer0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.runToolStripMenuItem,
            this.showNetworkOutputToolStripMenuItem,
            this.trainOutputLayerToolStripMenuItem,
            this.trainHiddenLayer0ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(652, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.testToolStripMenuItem.Text = "test";
			this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
			this.runToolStripMenuItem.Text = "showTargetFunction";
			this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
			// 
			// showNetworkOutputToolStripMenuItem
			// 
			this.showNetworkOutputToolStripMenuItem.Name = "showNetworkOutputToolStripMenuItem";
			this.showNetworkOutputToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
			this.showNetworkOutputToolStripMenuItem.Text = "showNetworkOutput";
			this.showNetworkOutputToolStripMenuItem.Click += new System.EventHandler(this.showNetworkOutputToolStripMenuItem_Click);
			// 
			// trainOutputLayerToolStripMenuItem
			// 
			this.trainOutputLayerToolStripMenuItem.Name = "trainOutputLayerToolStripMenuItem";
			this.trainOutputLayerToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
			this.trainOutputLayerToolStripMenuItem.Text = "trainOutputLayer";
			this.trainOutputLayerToolStripMenuItem.Click += new System.EventHandler(this.trainOutputLayerToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 249);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(652, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(652, 225);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// trainHiddenLayer0ToolStripMenuItem
			// 
			this.trainHiddenLayer0ToolStripMenuItem.Name = "trainHiddenLayer0ToolStripMenuItem";
			this.trainHiddenLayer0ToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
			this.trainHiddenLayer0ToolStripMenuItem.Text = "trainHiddenLayer0";
			this.trainHiddenLayer0ToolStripMenuItem.Click += new System.EventHandler(this.trainHiddenLayer0ToolStripMenuItem_Click);
			// 
			// Visualizer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 271);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Visualizer";
			this.Text = "Visualizer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNetworkOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainOutputLayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem trainHiddenLayer0ToolStripMenuItem;

    }
}