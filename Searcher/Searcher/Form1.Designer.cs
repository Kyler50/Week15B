namespace Searcher
{
    partial class Form1
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.resultList = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.patternBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(230, 250);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(101, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Show matches";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(141, 186);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search";
            // 
            // resultList
            // 
            this.resultList.FormattingEnabled = true;
            this.resultList.Location = new System.Drawing.Point(57, 279);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(444, 225);
            this.resultList.TabIndex = 2;
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(584, 168);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "";
            // 
            // patternBox
            // 
            this.patternBox.Location = new System.Drawing.Point(176, 202);
            this.patternBox.Name = "patternBox";
            this.patternBox.Size = new System.Drawing.Size(262, 20);
            this.patternBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 514);
            this.Controls.Add(this.patternBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ListBox resultList;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.TextBox patternBox;
    }
}

