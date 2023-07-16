namespace TestApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textSearch = new TextBox();
            label1 = new Label();
            RunSearch = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            textName = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textSearch
            // 
            textSearch.Location = new Point(184, 22);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(338, 23);
            textSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 25);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter Character:";
            // 
            // RunSearch
            // 
            RunSearch.Location = new Point(528, 22);
            RunSearch.Name = "RunSearch";
            RunSearch.Size = new Size(75, 23);
            RunSearch.TabIndex = 2;
            RunSearch.Text = "Search";
            RunSearch.UseVisualStyleBackColor = true;
            RunSearch.Click += RunSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textSearch);
            groupBox1.Controls.Add(RunSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 62);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Criteria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // textName
            // 
            textName.Location = new Point(60, 119);
            textName.Name = "textName";
            textName.ReadOnly = true;
            textName.Size = new Size(234, 23);
            textName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 127);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "PIcture:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(379, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 351);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(pictureBox1);
            Controls.Add(textName);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textSearch;
        private Label label1;
        private Button RunSearch;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textName;
        private Label label3;
        private PictureBox pictureBox1;
    }
}