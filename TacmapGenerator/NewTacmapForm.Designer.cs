namespace TacmapGenerator
{
    partial class NewTacmapForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.lengthTB = new System.Windows.Forms.TextBox();
            this.widthTB = new System.Windows.Forms.TextBox();
            this.generateTacmapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vertical Length (Up to 50 Supported):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horizontal Length (Up to 50 Supported):";
            // 
            // lengthTB
            // 
            this.lengthTB.Location = new System.Drawing.Point(221, 5);
            this.lengthTB.Name = "lengthTB";
            this.lengthTB.Size = new System.Drawing.Size(51, 20);
            this.lengthTB.TabIndex = 2;
            // 
            // widthTB
            // 
            this.widthTB.Location = new System.Drawing.Point(221, 49);
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(51, 20);
            this.widthTB.TabIndex = 3;
            // 
            // generateTacmapButton
            // 
            this.generateTacmapButton.Location = new System.Drawing.Point(135, 89);
            this.generateTacmapButton.Name = "generateTacmapButton";
            this.generateTacmapButton.Size = new System.Drawing.Size(137, 23);
            this.generateTacmapButton.TabIndex = 4;
            this.generateTacmapButton.Text = "Generate Tacmap";
            this.generateTacmapButton.UseVisualStyleBackColor = true;
            this.generateTacmapButton.Click += new System.EventHandler(this.generateTacmapButton_Click);
            // 
            // NewTacmapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.generateTacmapButton);
            this.Controls.Add(this.widthTB);
            this.Controls.Add(this.lengthTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewTacmapForm";
            this.Text = "NewTacmapForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lengthTB;
        private System.Windows.Forms.TextBox widthTB;
        private System.Windows.Forms.Button generateTacmapButton;
    }
}