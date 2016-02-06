using System;
using System.IO;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open my files";
            ofd.Filter = "text Files (*.txt)| *.txt|All Files (*.*)|*.*|Rich Text (*.rtf)|*.rtf";

            if(ofd.ShowDialog() == DialogResult.OK)

            {
                rtb.LoadFile(ofd.FileName,RichTextBoxStreamType.RichText);
            }

            this.Text = ofd.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save My Files";
            sfd.Filter = "text Files (*.txt)| *.txt|All Files (*.*)|*.*|Rich Text (*.rtf)|*.rtf";

            if (sfd.ShowDialog()==DialogResult.OK)

            {
                rtb.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);

            }



        }



    private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDia.Document = printDoc;

            printDia.ShowDialog();

        }

   
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Close();


        }

        private void fontMenu_Click(object sender, EventArgs e)
        {

            FontDialog fd = new FontDialog();
            fd.Font = rtb.Font;
            fd.ShowDialog();
            rtb.Font = fd.Font;


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {


            About ab = new About();
            ab.Show(); 

        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintMenu_Click(object sender, EventArgs e)
        {

            pageSetup.Document = printDoc;
            pageSetup.ShowDialog();


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Clear();
        }
    }
}
