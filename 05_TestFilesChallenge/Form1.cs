using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_TestFilesChallenge
{
    public partial class Form1 : Form
    {

        BindingList<UserModel> users = new BindingList<UserModel>();
        int firstNameOrder = 0;
        int lastNameOrder = 0;
        int ageOrder = 0;
        int isAliveOrder = 0;
        string fileName = "StandardDataSet.csv";

        public Form1()
        {
            InitializeComponent();

            LoadListFormFile();

            WireUpDropDown();
        }

        public void LoadListFormFile()
        {
            string[] lines = File.ReadAllLines(fileName);
            string[] headers = lines[0].Split(',');

            for(int i = 0; i < headers.Length; i++)
            {
                if (headers[i] == "FirstName")
                {
                    firstNameOrder = i;
                } 
                else if (headers[i] == "Lastname")
                {
                    lastNameOrder = i;
                }
                else if (headers[i] == "Age")
                {
                    ageOrder = i;
                }
                else if (headers[i] == "Isalive")
                {
                    isAliveOrder = i;
                }
            }

            for(int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');
                bool isAlive = false;

                if(columns[isAliveOrder] == "1")
                {
                    isAlive = true;
                }

                users.Add(new UserModel
                {
                    FirstName = columns[firstNameOrder],
                    LastName = columns[lastNameOrder],
                    Age = int.Parse(columns[ageOrder]),
                    IsAlive = bool.Parse(columns[isAliveOrder])
                });

            }
        }

        private void WireUpDropDown()
        {
            usersListBox.DataSource = users;
            usersListBox.DisplayMember = nameof(UserModel.DisplayText);

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            users.Add(new UserModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNametext.Text,
                Age = (int)agePicker.Value,
                IsAlive = isAliveCheckBox.Checked
            });

            firstNameText.Text = "";
            lastNametext.Text = "";
            agePicker.Value = 0;
            isAliveCheckBox.Checked = false;
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            string line = "";

            for(int i = 0; i < 4; i++)
            {
                if(firstNameOrder == 1)
                {
                    line += "FirstName";
                }
                else if (lastNameOrder == 1)
                {
                    line += "LastName";
                }
                else if (ageOrder == 1)
                {
                    line += "Age";
                }
                else if (isAliveOrder == 1)
                {
                    line += "IsAlive";
                }
                line += ",";
            }

            line = line.Substring(0, line.Length - 1);
            lines.Add(line);

            foreach(UserModel user in users)
            {
                int isAliveValue = 0;
                line = "";

                if(user.IsAlive == true)
                {
                    isAliveValue = 1;
                }

                for(int i = 0; i < 4; i++)
                {
                    if(firstNameOrder == i) {
                        line += user.FirstName;
                    }
                    else if (lastNameOrder == i)
                    {
                        line += user.LastName;
                    }
                    else if (ageOrder == i)
                    {
                        line += user.Age;
                    }
                    else if (isAliveOrder == i)
                    {
                        line += user.IsAlive;
                    }
                }

                lines.Add($"{ user.FirstName }, { user.LastName },{ user.Age },{ user.IsAlive }");
            }

            File.WriteAllLines("StandardDataSet.csv", lines);
            MessageBox.Show("Save Completed");
        }
    }
}
