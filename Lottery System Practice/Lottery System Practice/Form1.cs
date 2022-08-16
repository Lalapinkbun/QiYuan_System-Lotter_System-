using System;
using System.Windows.Forms;

namespace Lottery_System_Practice
{
    public partial class The_Lottery_System : Form
    {
        
        string hasGetting;
        string[] hasGettingTen = new string[10];
        int hasGettingnum = 0;
        int hasGettingnnuTen = 0;
        Random rdGetting = new Random();

        int MinimumGet80 = 80;
        int MinimunPlayerGet = 80;
        int PlayerhasGetMax = 0;
        int PlayerhasGet = 0;
        int PlayerhasGetmom = 0;

        public The_Lottery_System()
        {
            InitializeComponent();
            labMinPlayerGet.Text = MinimumGet80.ToString();
        }

        private void btnGetOne_Click(object sender, EventArgs e)
        {
            //int rdnum = rdGetting.Next(hasGetting[] = "四星");
            hasGettingnum = rdGetting.Next(0, 11);

            if (hasGettingnum >= 10) // 9,10,12
            {
                hasGetting = "5 Star";
                MinimunPlayerGet = 80;
                PlayerhasGetmom = 0;

            }
            else if (hasGettingnum < 10 && hasGettingnum > 4) // 5~9
            {
                hasGetting = "4 Star";
                MinimunPlayerGet--;
                PlayerhasGetMax++;
                PlayerhasGetmom++;
            }
            else
            {
                hasGetting = "3 Star";
                MinimunPlayerGet--;
                PlayerhasGetMax++;
                PlayerhasGetmom++;
            }

            if (PlayerhasGetmom == MinimumGet80)
            {
                hasGetting = "5 Star";
                MinimunPlayerGet = 80;
                PlayerhasGetmom = 0;
            }
                

            MessageBox.Show(hasGetting, "Get One", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            PlayerhasGet++;

            labPlayerHasGet.Text = PlayerhasGet.ToString();

            labMinPlayerGet.Text = MinimunPlayerGet.ToString();

            //if (MinimunPlayerGet >= 0)
            //    MinimunPlayerGet = 80;
        }

        private void btnGetTen_Click(object sender, EventArgs e)
        {
            int index = 0;
            while (index < 10)
            {
                hasGettingnum = rdGetting.Next(0, 11);

                if (hasGettingnum >= 10) // 10,11,12
                {
                    hasGettingTen[hasGettingnnuTen] = "5 Star ";
                    MinimunPlayerGet = 80;
                    PlayerhasGetmom = 0;
                }
                else if (hasGettingnum < 10 && hasGettingnum > 4) // 5~9
                {
                    hasGettingTen[hasGettingnnuTen] = "4 Star ";
                    if (hasGettingnum < 10)
                    {
                        PlayerhasGetMax++;
                        PlayerhasGetmom++;
                    }
                }
                else
                {
                    hasGettingTen[hasGettingnnuTen] = "3 Star ";
                    if (hasGettingnum < 10)
                    {
                        PlayerhasGetMax++;
                        PlayerhasGetmom++;
                    }
                }

                if (hasGettingnum < 10)
                    MinimunPlayerGet--;

                PlayerhasGet++;
                hasGettingnnuTen++;
                index++;
            }

            if (PlayerhasGetmom == MinimumGet80)
            {
                hasGettingTen[0] = "5 Star ";
                MinimunPlayerGet = 80;
                PlayerhasGetmom = 0;
            }


            MessageBox.Show(hasGettingTen[0] + hasGettingTen[1] + hasGettingTen[2] + hasGettingTen[3] + hasGettingTen[4] + hasGettingTen[5]
                + hasGettingTen[6] + hasGettingTen[7] + hasGettingTen[8] + hasGettingTen[9], "Get Ten", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            hasGettingnnuTen -= 10;

            labPlayerHasGet.Text = PlayerhasGet.ToString();

            
            labMinPlayerGet.Text = MinimunPlayerGet.ToString();

            //if (MinimunPlayerGet <= 0)
            //    MinimunPlayerGet = 80;
        }
    }
}
