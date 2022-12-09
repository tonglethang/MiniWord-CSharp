using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongLeThang_MiniWord
{
    public partial class frmThang : Form
    {
        public frmThang()
        {
            InitializeComponent();
            ReadFont();
            ReadFontSize();
        }
/*        bool Ktra = false;*/
        String path = "";
        bool check = false;
/*        private bool checkFile = false;*/
        private string pathTmp = "";
        private void saveFile()
        {
            SaveFileDialog type = new SaveFileDialog();
            type.Filter = "Save File (*.rtf)|*.rtf";

            if (type.ShowDialog() == DialogResult.OK)
            {


                path = type.FileName;
                if (path != "")
                {
                    richText.SaveFile(path);
                    check = true;
                    pathTmp = path;
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            path = open.FileName;
            if (path != "")
            {
                richText.Visible = true;
                richText.LoadFile(path);
                check = true;
                pathTmp = path;
            }

        }
        private void ReadFontSize()
        {
            for(int i = 1; i <= 30; i++)
            {
                cbbFontSize.Items.Add(i.ToString());
            }
            cbbFontSize.SelectedItem = 12;
        }

        private void ReadFont()
        {
            foreach(FontFamily font in FontFamily.Families)
            {
                cbbFontText.Items.Add(font.Name);
            }
            cbbFontText.SelectedItem = "Times New Roman";
        }

        private void desingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        string fontName = "Times new roman";
        float fontSize = 13;
        private void cbbFontText_SelectedIndexChanged(object sender, EventArgs e)
        {
             fontName = cbbFontText.SelectedItem.ToString();
             fontSize = float.Parse(cbbFontSize.SelectedItem.ToString());
             richText.SelectionFont = new Font(fontName, fontSize);
        }

        private void cbbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontName = cbbFontText.SelectedItem.ToString();
            fontSize = float.Parse(cbbFontSize.SelectedItem.ToString());
            richText.SelectionFont = new Font(fontName, fontSize);
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            btnFontColor.BackColor = color.Color;
            richText.SelectionColor = color.Color;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check = false;
            richText.Visible = true;
            richText.Text = String.Empty;
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openFile();
            }

            catch (Exception)
            {
                MessageBox.Show("File không đúng định dang !\n" + "Chỉ chấp nhận file có dạng *.rtf", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (check)
            {
                richText.SaveFile(pathTmp);
            }
            else
            {
                saveFile();
            }
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            richText.Visible = false;
            check = false;
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                DialogResult dlr =  MessageBox.Show("Bạn có muốn lưu file ?\n", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    saveFile();
                    Application.Exit();
                }
                Application.Exit();
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình ?",
                     "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    richText.SaveFile(pathTmp);
                    Application.Exit();
                }

            }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "Image|*.bmp;*.jpg;*.gif;*.png;*.tif";
            image.ShowDialog();
            string path = image.FileName;
            if (path != "")
            {
                Clipboard.SetImage(Image.FromFile(path));
                richText.Paste();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (richText.SelectionLength > 0)
                richText.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richText.SelectionLength > 0)
                richText.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                richText.Paste();
        }
    }
}
