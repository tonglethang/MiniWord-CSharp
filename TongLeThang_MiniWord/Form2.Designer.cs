namespace TongLeThang_MiniWord
{
    partial class frmFind
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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbWhole = new System.Windows.Forms.CheckBox();
            this.cbCase = new System.Windows.Forms.CheckBox();
            this.rbtnDown = new System.Windows.Forms.RadioButton();
            this.rbtnUp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(110, 29);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(302, 28);
            this.txtFind.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Replace:";
            // 
            // txtReplace
            // 
            this.txtReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplace.Location = new System.Drawing.Point(110, 76);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(302, 28);
            this.txtReplace.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(448, 29);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 28);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Find next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(448, 76);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(112, 28);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(448, 123);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(112, 28);
            this.btnReplaceAll.TabIndex = 6;
            this.btnReplaceAll.Text = "Replace all";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(448, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbWhole
            // 
            this.cbWhole.AutoSize = true;
            this.cbWhole.Location = new System.Drawing.Point(57, 131);
            this.cbWhole.Name = "cbWhole";
            this.cbWhole.Size = new System.Drawing.Size(128, 20);
            this.cbWhole.TabIndex = 8;
            this.cbWhole.Text = "Math whole word";
            this.cbWhole.UseVisualStyleBackColor = true;
            // 
            // cbCase
            // 
            this.cbCase.AutoSize = true;
            this.cbCase.Location = new System.Drawing.Point(57, 175);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(91, 20);
            this.cbCase.TabIndex = 9;
            this.cbCase.Text = "Math case";
            this.cbCase.UseVisualStyleBackColor = true;
            // 
            // rbtnDown
            // 
            this.rbtnDown.AutoSize = true;
            this.rbtnDown.Checked = true;
            this.rbtnDown.Location = new System.Drawing.Point(104, 34);
            this.rbtnDown.Name = "rbtnDown";
            this.rbtnDown.Size = new System.Drawing.Size(62, 20);
            this.rbtnDown.TabIndex = 10;
            this.rbtnDown.TabStop = true;
            this.rbtnDown.Text = "Down";
            this.rbtnDown.UseVisualStyleBackColor = true;
            // 
            // rbtnUp
            // 
            this.rbtnUp.AutoSize = true;
            this.rbtnUp.Location = new System.Drawing.Point(33, 34);
            this.rbtnUp.Name = "rbtnUp";
            this.rbtnUp.Size = new System.Drawing.Size(46, 20);
            this.rbtnUp.TabIndex = 11;
            this.rbtnUp.TabStop = true;
            this.rbtnUp.Text = "Up";
            this.rbtnUp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnUp);
            this.groupBox1.Controls.Add(this.rbtnDown);
            this.groupBox1.Location = new System.Drawing.Point(224, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search direction";
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 233);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCase);
            this.Controls.Add(this.cbWhole);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Name = "frmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Replace";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbWhole;
        private System.Windows.Forms.CheckBox cbCase;
        private System.Windows.Forms.RadioButton rbtnDown;
        private System.Windows.Forms.RadioButton rbtnUp;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}