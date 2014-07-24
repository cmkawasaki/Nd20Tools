namespace TacmapGenerator
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTacmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTacmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTacmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stencilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlePointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permitMovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useGroupMovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.initLabel = new System.Windows.Forms.Label();
            this.initTextBox = new System.Windows.Forms.TextBox();
            this.tacmapFrame1 = new TacmapGenerator.TacmapFrame();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character To Paint:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 12);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save Tacmap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(347, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 343);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Copy To Clipboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stencilToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTacmapToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadTacmapToolStripMenuItem,
            this.resetTacmapToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripSeparator1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTacmapToolStripMenuItem
            // 
            this.newTacmapToolStripMenuItem.Name = "newTacmapToolStripMenuItem";
            this.newTacmapToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.newTacmapToolStripMenuItem.Text = "New Tacmap";
            this.newTacmapToolStripMenuItem.Click += new System.EventHandler(this.newTacmapToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveToolStripMenuItem.Text = "Save Tacmap to File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadTacmapToolStripMenuItem
            // 
            this.loadTacmapToolStripMenuItem.Name = "loadTacmapToolStripMenuItem";
            this.loadTacmapToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.loadTacmapToolStripMenuItem.Text = "Load Tacmap from File";
            this.loadTacmapToolStripMenuItem.Click += new System.EventHandler(this.loadTacmapToolStripMenuItem_Click);
            // 
            // resetTacmapToolStripMenuItem
            // 
            this.resetTacmapToolStripMenuItem.Name = "resetTacmapToolStripMenuItem";
            this.resetTacmapToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.resetTacmapToolStripMenuItem.Text = "Reset Tacmap";
            this.resetTacmapToolStripMenuItem.Click += new System.EventHandler(this.resetTacmapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // stencilToolStripMenuItem
            // 
            this.stencilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlePointToolStripMenuItem,
            this.lineToolStripMenuItem});
            this.stencilToolStripMenuItem.Name = "stencilToolStripMenuItem";
            this.stencilToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.stencilToolStripMenuItem.Text = "Stencil";
            // 
            // singlePointToolStripMenuItem
            // 
            this.singlePointToolStripMenuItem.Name = "singlePointToolStripMenuItem";
            this.singlePointToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.singlePointToolStripMenuItem.Text = "Single Point";
            this.singlePointToolStripMenuItem.Click += new System.EventHandler(this.singlePointToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permitMovementToolStripMenuItem,
            this.useGroupMovementToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // permitMovementToolStripMenuItem
            // 
            this.permitMovementToolStripMenuItem.Name = "permitMovementToolStripMenuItem";
            this.permitMovementToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.permitMovementToolStripMenuItem.Text = "Permit Movement";
            this.permitMovementToolStripMenuItem.Click += new System.EventHandler(this.permitMovementToolStripMenuItem_Click);
            // 
            // useGroupMovementToolStripMenuItem
            // 
            this.useGroupMovementToolStripMenuItem.Name = "useGroupMovementToolStripMenuItem";
            this.useGroupMovementToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.useGroupMovementToolStripMenuItem.Text = "Use Group Movement";
            this.useGroupMovementToolStripMenuItem.Click += new System.EventHandler(this.useGroupMovementToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.initLabel);
            this.panel2.Controls.Add(this.initTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 34);
            this.panel2.TabIndex = 6;
            // 
            // initLabel
            // 
            this.initLabel.AutoSize = true;
            this.initLabel.Location = new System.Drawing.Point(12, 4);
            this.initLabel.Name = "initLabel";
            this.initLabel.Size = new System.Drawing.Size(46, 13);
            this.initLabel.TabIndex = 1;
            this.initLabel.Text = "Initiative";
            // 
            // initTextBox
            // 
            this.initTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.initTextBox.Location = new System.Drawing.Point(64, 3);
            this.initTextBox.Name = "initTextBox";
            this.initTextBox.Size = new System.Drawing.Size(217, 20);
            this.initTextBox.TabIndex = 0;
            // 
            // tacmapFrame1
            // 
            this.tacmapFrame1.HeightTiles = 10;
            this.tacmapFrame1.Location = new System.Drawing.Point(15, 24);
            this.tacmapFrame1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tacmapFrame1.Name = "tacmapFrame1";
            this.tacmapFrame1.Size = new System.Drawing.Size(283, 288);
            this.tacmapFrame1.TabIndex = 7;
            this.tacmapFrame1.WidthTiles = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 367);
            this.Controls.Add(this.tacmapFrame1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Tacmap Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTacmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stencilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singlePointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetTacmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permitMovementToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label initLabel;
        private System.Windows.Forms.TextBox initTextBox;
        private TacmapFrame tacmapFrame1;
        private System.Windows.Forms.ToolStripMenuItem loadTacmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useGroupMovementToolStripMenuItem;
    }
}

