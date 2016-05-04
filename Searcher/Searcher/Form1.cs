using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Searcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultList.Items.Clear();
            foreach (var line in textBox.Lines)
            {
                MatchCollection matchCollection = Regex.Matches(line, patternBox.Text);

                if (matchCollection.Count > 0)
                {
                    foreach (System.Text.RegularExpressions.Match match in matchCollection)
                    {
                        resultList.Items.Add(match);
                    }
                }
            }
        }
    }
}
