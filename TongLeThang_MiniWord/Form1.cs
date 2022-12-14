using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            cbbFontSize.SelectedItem = 15;
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
        float fontSize = 15;
        private void cbbFontText_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontName = cbbFontText.SelectedItem.ToString();
            richText.SelectionFont = new Font(fontName, fontSize, (checkBold ? FontStyle.Bold : 0) | (checkUnderline ? FontStyle.Underline : 0 ) | (checkItalic ? FontStyle.Italic : 0));
        }

        private void cbbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontSize = float.Parse(cbbFontSize.SelectedItem.ToString());
            richText.SelectionFont = new Font(fontName, fontSize, (checkBold ? FontStyle.Bold : 0) | (checkUnderline ? FontStyle.Underline : 0) | (checkItalic ? FontStyle.Italic : 0));
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if(color.ShowDialog() == DialogResult.OK)
            {
                btnFontColor.BackColor = color.Color;
                richText.SelectionColor = color.Color;
            }
        }
        private void btnHighLight_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                btnHighLight.BackColor = color.Color;
                richText.SelectionBackColor = color.Color;
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check = false;
            pathTmp = "";
            richText.Visible = true;
            richText.Text = String.Empty;
            richText.SelectionFont = new Font(fontName, fontSize);
            richText.SelectionAlignment = HorizontalAlignment.Left;
            richText.ForeColor = Color.Black;
            btnBold.BackColor = Color.Transparent;
            btnItalic.BackColor = Color.Transparent;
            btnUnderline.BackColor = Color.Transparent;
            btnLeft.BackColor = Color.Aqua;
            btnRight.BackColor = Color.Transparent;
            btnCenter.BackColor = Color.Transparent;
            btnFontColor.BackColor = Color.Transparent;
            btnFontColor.BackColor = Color.Transparent;
            btnHighLight.BackColor = Color.Transparent;
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
            checkSave = true;
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            if (!checkSave)
            {
                if(!check && richText.TextLength > 0)
                {
                    DialogResult dlr = MessageBox.Show("Bạn có muốn lưu file ?\n", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        saveFile();
                        richText.Visible = false;
                        check = false;
                    }
                    else
                    {
                        richText.Visible = false;
                        check = false;
                    }
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Bạn có muốn lưu các thay đổi ?",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            richText.SaveFile(pathTmp);
                            richText.Visible = false;
                            check = false;
                         }
                        else
                         {
                            richText.Visible = false;
                            check = false;
                        }
                }
            }
            else
            {
                richText.Visible = false;
                check = false;
            }
        }
        bool checkSave = true;
        private void richText_TextChanged(object sender, EventArgs e)
        {
            checkSave = false;
        }
        private void frmThang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!checkSave)
            {
                if (!check && richText.TextLength > 0)
                {
                    DialogResult dlr = MessageBox.Show("Bạn có muốn lưu file ?\n", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        saveFile();
                    }
                    else if (dlr == DialogResult.No)
                    {

                    }
                    else
                    {
                        e.Cancel = true;
                    }

                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Bạn có muốn lưu các thay đổi ?",
                         "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        richText.SaveFile(pathTmp);
                        Application.Exit();
                    }

                }
            }
        }

        private void frmThang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void menuUndo_Click(object sender, EventArgs e)
        {
            richText.Undo();
        }

        private void menuRedo_Click(object sender, EventArgs e)
        {
            richText.Redo();
        }
        bool checkBold = false;
        bool checkUnderline = false;
        bool checkItalic = false;
        private void btnBold_Click(object sender, EventArgs e)
        {
            if (!checkBold)
            {
                btnBold.BackColor = Color.Aqua;
                richText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Bold | (checkItalic ? FontStyle.Italic : 0) | (checkUnderline ? FontStyle.Underline : 0)));
                checkBold = true;
            }
            else
            {
                btnBold.BackColor = Color.Transparent;
                richText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular | (checkItalic ? FontStyle.Italic : 0) | (checkUnderline ? FontStyle.Underline : 0)));
                checkBold = false;
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (!checkUnderline)
            {
                btnUnderline.BackColor = Color.Aqua;
                richText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Underline | (checkItalic ? FontStyle.Italic : 0) | (checkBold ? FontStyle.Bold : 0)));
                checkUnderline = true;
            }
            else
            {
                btnUnderline.BackColor = Color.Transparent;
                richText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular | (checkItalic ? FontStyle.Italic : 0) | (checkBold ? FontStyle.Bold : 0)));
                checkUnderline = false;
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (!checkItalic)
            {
                btnItalic.BackColor = Color.Aqua;
                richText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Italic | (checkUnderline ? FontStyle.Underline : 0) | (checkBold ? FontStyle.Bold : 0)));
                checkItalic = true;
            }
            else
            {
                btnItalic.BackColor = Color.Transparent;
                richText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular| (checkUnderline ? FontStyle.Underline : 0) | (checkBold ? FontStyle.Bold : 0)));
                checkItalic = false;
            }
        }
        bool checkLeft = false;
        bool checkRight = false;
        bool checkCenter = false;
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (!checkLeft)
            {
                richText.SelectionAlignment = HorizontalAlignment.Left;
                btnLeft.BackColor = Color.Aqua;
                btnCenter.BackColor = Color.Transparent;
                btnRight.BackColor = Color.Transparent;
                checkLeft = true;
                checkCenter = false;
                checkRight = false;
            }
    
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            if (!checkCenter)
            {
                richText.SelectionAlignment = HorizontalAlignment.Center;
                btnCenter.BackColor = Color.Aqua;
                btnLeft.BackColor = Color.Transparent;
                btnRight.BackColor = Color.Transparent;
                checkLeft = false;
                checkCenter = true;
                checkRight = false;
            }
        
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (!checkRight)
            {
                richText.SelectionAlignment = HorizontalAlignment.Right;
                btnRight.BackColor = Color.Aqua;
                btnLeft.BackColor = Color.Transparent;
                btnCenter.BackColor = Color.Transparent;
                checkLeft = false;
                checkCenter = false;
                checkRight = true;
            }
     
        }
        float zoom = 1;
        private void btnIn_Click(object sender, EventArgs e)
        {
            if(zoom >= 80)
            {
                zoom = 80;
            }
            else
            {
                zoom += 2;
                richText.ZoomFactor = zoom;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (zoom <= 1)
            {
                zoom = 1;
            }
            else
            {
                zoom -= 2;
                richText.ZoomFactor = zoom;
            }
        }

        private void menuFind_Click(object sender, EventArgs e)
        {
            frmFind frmFind = new frmFind(richText, this);
            frmFind.Show();
        }

        private void menuSelectAll_Click(object sender, EventArgs e)
        {
            richText.SelectAll();
        }

        private void iconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Documents\WinForm\TongLeThang_MiniWord\TongLeThang_MiniWord\icon");
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    this.imageList1.Images.Add(Image.FromFile(file.FullName));
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }
            this.listView1.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(32, 32);
            this.listView1.LargeImageList = this.imageList1;

            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listView1.Items.Add(item);
            }

            listView1.Visible = true;
        }
        int pos = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (listView1.FocusedItem == null) return;
                pos = listView1.SelectedIndices[0];
                Clipboard.SetImage(imageList1.Images[pos]);
                richText.Paste();
            }
            catch (Exception)
            {
                return;
            }

            listView1.Visible = false;
        }

        private void listView1_MouseLeave(object sender, EventArgs e)
        {
            listView1.Visible = false;
        }
    }
}
