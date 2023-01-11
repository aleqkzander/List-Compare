
namespace List_Compare
{
    partial class Start
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
            this.OpenFirstList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearFirstList = new System.Windows.Forms.Button();
            this.FirstListBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SecondListBox = new System.Windows.Forms.RichTextBox();
            this.ClearSecondList = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.OpenSecondList = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CompareList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreListOne = new System.Windows.Forms.Label();
            this.ScoreListTwo = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFirstList
            // 
            this.OpenFirstList.Location = new System.Drawing.Point(6, 19);
            this.OpenFirstList.Name = "OpenFirstList";
            this.OpenFirstList.Size = new System.Drawing.Size(75, 23);
            this.OpenFirstList.TabIndex = 0;
            this.OpenFirstList.Text = "Open";
            this.OpenFirstList.UseVisualStyleBackColor = true;
            this.OpenFirstList.Click += new System.EventHandler(this.OpenFirstList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResultLabel);
            this.groupBox1.Controls.Add(this.ScoreListOne);
            this.groupBox1.Controls.Add(this.CompareList);
            this.groupBox1.Controls.Add(this.FirstListBox);
            this.groupBox1.Controls.Add(this.ClearFirstList);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.OpenFirstList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First List";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(305, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fist List";
            // 
            // ClearFirstList
            // 
            this.ClearFirstList.Location = new System.Drawing.Point(87, 19);
            this.ClearFirstList.Name = "ClearFirstList";
            this.ClearFirstList.Size = new System.Drawing.Size(75, 23);
            this.ClearFirstList.TabIndex = 3;
            this.ClearFirstList.Text = "Clear";
            this.ClearFirstList.UseVisualStyleBackColor = true;
            this.ClearFirstList.Click += new System.EventHandler(this.ClearFirstList_Click);
            // 
            // FirstListBox
            // 
            this.FirstListBox.Location = new System.Drawing.Point(6, 48);
            this.FirstListBox.Name = "FirstListBox";
            this.FirstListBox.Size = new System.Drawing.Size(288, 249);
            this.FirstListBox.TabIndex = 4;
            this.FirstListBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ScoreListTwo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.SecondListBox);
            this.groupBox3.Controls.Add(this.ClearSecondList);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.OpenSecondList);
            this.groupBox3.Location = new System.Drawing.Point(318, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 355);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Second List";
            // 
            // SecondListBox
            // 
            this.SecondListBox.Location = new System.Drawing.Point(6, 48);
            this.SecondListBox.Name = "SecondListBox";
            this.SecondListBox.Size = new System.Drawing.Size(288, 249);
            this.SecondListBox.TabIndex = 4;
            this.SecondListBox.Text = "";
            // 
            // ClearSecondList
            // 
            this.ClearSecondList.Location = new System.Drawing.Point(87, 19);
            this.ClearSecondList.Name = "ClearSecondList";
            this.ClearSecondList.Size = new System.Drawing.Size(75, 23);
            this.ClearSecondList.TabIndex = 3;
            this.ClearSecondList.Text = "Clear";
            this.ClearSecondList.UseVisualStyleBackColor = true;
            this.ClearSecondList.Click += new System.EventHandler(this.ClearSecondList_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(305, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fist List";
            // 
            // OpenSecondList
            // 
            this.OpenSecondList.Location = new System.Drawing.Point(6, 19);
            this.OpenSecondList.Name = "OpenSecondList";
            this.OpenSecondList.Size = new System.Drawing.Size(75, 23);
            this.OpenSecondList.TabIndex = 0;
            this.OpenSecondList.Text = "Open";
            this.OpenSecondList.UseVisualStyleBackColor = true;
            this.OpenSecondList.Click += new System.EventHandler(this.OpenSecondList_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // CompareList
            // 
            this.CompareList.Location = new System.Drawing.Point(168, 19);
            this.CompareList.Name = "CompareList";
            this.CompareList.Size = new System.Drawing.Size(75, 23);
            this.CompareList.TabIndex = 5;
            this.CompareList.Text = "Compare";
            this.CompareList.UseVisualStyleBackColor = true;
            this.CompareList.Click += new System.EventHandler(this.CompareList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TEXT TO COMPARE";
            // 
            // ScoreListOne
            // 
            this.ScoreListOne.AutoSize = true;
            this.ScoreListOne.Location = new System.Drawing.Point(6, 300);
            this.ScoreListOne.Name = "ScoreListOne";
            this.ScoreListOne.Size = new System.Drawing.Size(62, 13);
            this.ScoreListOne.TabIndex = 6;
            this.ScoreListOne.Text = "SCORE: 00";
            // 
            // ScoreListTwo
            // 
            this.ScoreListTwo.AutoSize = true;
            this.ScoreListTwo.Location = new System.Drawing.Point(6, 300);
            this.ScoreListTwo.Name = "ScoreListTwo";
            this.ScoreListTwo.Size = new System.Drawing.Size(62, 13);
            this.ScoreListTwo.TabIndex = 7;
            this.ScoreListTwo.Text = "SCORE: 00";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(6, 339);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(68, 13);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "RESULT: 00";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Start";
            this.Text = "List Compare";
            this.Load += new System.EventHandler(this.Start_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenFirstList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClearFirstList;
        private System.Windows.Forms.RichTextBox FirstListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox SecondListBox;
        private System.Windows.Forms.Button ClearSecondList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button OpenSecondList;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button CompareList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreListOne;
        private System.Windows.Forms.Label ScoreListTwo;
        private System.Windows.Forms.Label ResultLabel;
    }
}

