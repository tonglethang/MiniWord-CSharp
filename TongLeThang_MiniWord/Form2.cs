using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongLeThang_MiniWord
{
    public partial class frmFind : Form
    {
        private RichTextBox richTxt = new RichTextBox();
        private frmThang frm = new frmThang(); 
        public frmFind(RichTextBox richText, frmThang frmTmp)
        {
            InitializeComponent();
            richTxt = richText;
            frm = frmTmp;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtFind.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập từ cần tìm !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Find(richTxt, txtFind.Text.ToString(), cbCase.Checked, cbWhole.Checked, rbtnUp.Checked);
            }
        }
        private int Find(RichTextBox richText, string text, bool matchCase, bool matchWholeWord, bool directionUp)
        {
            RichTextBoxFinds options = new RichTextBoxFinds();
            int index = new int();
            if (matchCase)
                options |= RichTextBoxFinds.MatchCase;
            if (matchWholeWord)
            {
                options |= RichTextBoxFinds.WholeWord;
            }
            if (directionUp)
                options |= RichTextBoxFinds.Reverse;

            if (directionUp)
                index = richText.Find(text, 0, richText.SelectionStart, options);
            else
                index = richText.Find(text, richText.SelectionStart + richText.SelectionLength, options);

            if (index >= 0)
            {
                richText.SelectionStart = index;
                richText.SelectionLength = text.Length;
                frm.Focus();
            }
            else
            {
                MessageBox.Show("Không tìm thấy từ cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return index;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            int i = Find(richTxt, txtFind.Text, cbCase.Checked, cbWhole.Checked, rbtnUp.Checked);
            if (txtFind.Text == "")
                MessageBox.Show("Vui lòng nhập từ cần tìm !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (txtReplace.Text == "")
                MessageBox.Show("Vui lòng nhập từ cần thay thế !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (richTxt.SelectedText != "")
                richTxt.SelectedText = txtReplace.Text;
        }
        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            int i = Find(richTxt, txtFind.Text, cbCase.Checked, cbWhole.Checked, rbtnUp.Checked);
            if (txtFind.Text == "")
                MessageBox.Show("Vui lòng nhập từ cần tìm !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (txtReplace.Text == "")
                MessageBox.Show("Vui lòng nhập từ cần thay thế !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (i != 0)
                richTxt.Text = richTxt.Text.Replace(txtFind.Text, txtReplace.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
