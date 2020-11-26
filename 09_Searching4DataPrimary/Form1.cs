using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Searching4DataPrimary
{
    public partial class Form1 : Form
    {
        BindingList<string> matchedLines = new BindingList<string>();
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = matchedLines;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(@"C:\Users\byfra\Documents\CFGS2\SPDVI\1. avaluació\1. Topic\Visual Studio\exercisesReviewCS\exercisesReviewCS\09_Searching4DataPrimary\bin\Debug\Searching4Data_primary.txt").ToList();
            matchedLines.Clear();
            foreach (var line in lines)
            {
                if(line.IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    matchedLines.Add(line);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileText = File.ReadAllText(@"C:\Users\byfra\Documents\CFGS2\SPDVI\1. avaluació\1. Topic\Visual Studio\exercisesReviewCS\exercisesReviewCS\09_Searching4DataPrimary\bin\Debug\Searching4Data_primary.txt");
            matchedLines.Clear();

            Regex regex = new Regex(@" \(([0-9]{3})\) ([0-9]{3})-([0-9]{4}) ");
            MatchCollection matches = regex.Matches(fileText);

            foreach(Match  match in matches)
            {
                if(string.IsNullOrWhiteSpace(match.Groups[0].Value) == false)
                {
                    matchedLines.Add(match.Groups[0].Value.Trim());
                }
            }
        }
    }
}
