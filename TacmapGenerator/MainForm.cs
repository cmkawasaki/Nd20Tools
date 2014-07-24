using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;

namespace TacmapGenerator
{
    public partial class MainForm : Form
    {
        NewTacmapForm newTacmapForm;

        public MainForm()
        {
            InitializeComponent();
            //Populate Drop down list
            tacmapFrame1.tacmapView1.CurrentStencil = StencilType.SINGLE_POINT;
            singlePointToolStripMenuItem.Checked = true;
            tacmapFrame1.tacmapView1.DraggingMovementSwitch = true;
            tacmapFrame1.tacmapView1.GroupMovementSwitch = true;
            permitMovementToolStripMenuItem.Checked = true;
            useGroupMovementToolStripMenuItem.Checked = true;

        }

        public void RedrawTacmap(int width, int length)
        {
            tacmapFrame1.ResizeControl(width, length);
            //Insert code to resize form
            int newWidth = tacmapFrame1.Width + panel1.Width + (tacmapFrame1.tacmapView1.PixelPerTile * 2);
            int newLength = Math.Max(tacmapFrame1.Height, 295) + menuStrip1.Height + (tacmapFrame1.tacmapView1.PixelPerTile * 3) + panel2.Height;
            this.Width = newWidth;
            this.Height = newLength;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                tacmapFrame1.tacmapView1.TacmapLetter = textBox1.Text[0];
            }
            else
            {
                tacmapFrame1.tacmapView1.TacmapLetter = ' ';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tacmapFrame1.tacmapView1.Print(".\\Current.txt", initTextBox.Text);

            MessageBox.Show("Tacmap Saved!");
        }

        private void newTacmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTacmapForm = new NewTacmapForm();
            newTacmapForm.myParentForm = this;
            newTacmapForm.ShowDialog();
        }

        private void singlePointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tacmapFrame1.tacmapView1.CurrentStencil = StencilType.SINGLE_POINT;
            singlePointToolStripMenuItem.Checked = true;
            lineToolStripMenuItem.Checked = false;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tacmapFrame1.tacmapView1.CurrentStencil = StencilType.LINE;
            singlePointToolStripMenuItem.Checked = false;
            lineToolStripMenuItem.Checked = true;
        }

        private void resetTacmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tacmapFrame1.ResizeControl(tacmapFrame1.WidthTiles, tacmapFrame1.HeightTiles);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tacmapFrame1.tacmapView1.CopyToClipboard(initTextBox.Text);
        }

        private void permitMovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permitMovementToolStripMenuItem.Checked == true)
            {
                tacmapFrame1.tacmapView1.DraggingMovementSwitch = false; ;
                permitMovementToolStripMenuItem.Checked = false;
            }
            else
            {
                tacmapFrame1.tacmapView1.DraggingMovementSwitch = true;
                permitMovementToolStripMenuItem.Checked = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.AddExtension = true;
            saveDialog.DefaultExt = "tac";
            saveDialog.Filter = "tac files (*.tac)|*.tac";
            saveDialog.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult result = saveDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(TacmapData));

                using (XmlDictionaryWriter writer = XmlDictionaryWriter.CreateTextWriter(new StreamWriter(saveDialog.FileName).BaseStream, Encoding.UTF8, true))
                {
                    serializer.WriteObject(writer, this.tacmapFrame1.tacmapView1.TacmapData);
                }

                MessageBox.Show("Tacmap Saved!");
            }
        }

        private void loadTacmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.AddExtension = true;
            openDialog.DefaultExt = "tac";
            openDialog.Filter = "tac files (*.tac)|*.tac";
            openDialog.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult result = openDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {

                DataContractSerializer serializer = new DataContractSerializer(typeof(TacmapData));

                using (XmlDictionaryReader writer = XmlDictionaryReader.CreateTextReader(new StreamReader(openDialog.FileName).BaseStream, XmlDictionaryReaderQuotas.Max))
                {
                    TacmapData itemToProcess = (TacmapData)serializer.ReadObject(writer);
                    this.tacmapFrame1.ResizeControl(itemToProcess.Width, itemToProcess.Height);
                    this.tacmapFrame1.tacmapView1.TacmapData = itemToProcess;
                    this.tacmapFrame1.Refresh();
                }

                MessageBox.Show("Tacmap Loaded!");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData & Keys.Control) == Keys.Control && (keyData & Keys.Shift) == Keys.Shift)
            {
                Keys keyData2 = (Keys)((int)keyData & 0x000000FF);

                if (keyData2 != 0)
                {
                    KeysConverter converter = new KeysConverter();
                    if (keyData2 >= Keys.A && keyData2 <= Keys.Z)
                    {
                        int item = keyData2 - Keys.A;
                        char item2 = (char)('A' + item);
                        this.textBox1.Text = item2.ToString();
                    }
                    else if (keyData2 >= Keys.D1 && keyData2 <= Keys.D9)
                    {
                        int item = keyData2 - Keys.D1;
                        char item2 = (char)('1' + item);
                        this.textBox1.Text = item2.ToString();
                    }
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void useGroupMovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (useGroupMovementToolStripMenuItem.Checked == true)
            {
                tacmapFrame1.tacmapView1.GroupMovementSwitch = false;
                useGroupMovementToolStripMenuItem.Checked = false;
            }
            else
            {
                tacmapFrame1.tacmapView1.GroupMovementSwitch = true;
                useGroupMovementToolStripMenuItem.Checked = true;
            }
        }
    }


}
