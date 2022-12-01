using System.IO;


namespace PhotoGrabber
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            textBox5.ReadOnly= true;
            textBox6.ReadOnly= true;
            textBox2.ReadOnly= true;
            textBox4.ReadOnly= true;


            // Yhe

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string userURL = textBox1.Text;
            string downloadFolder = textBox3.Text;
            string superUrl = " ";
            int var = 0;
            if (textBox2.Text == "r/")
            {
                superUrl = "https://www.popular.pics/reddit/subreddits/posts?r=" + userURL;
                superUrl = customLinkFilter(superUrl, comboBox1.Text, textBox2.Text, comboBox2.Text);
      
            }
            else if (textBox2.Text == "u/")
            {

                superUrl = "https://www.popular.pics/reddit/u/" + userURL;
                superUrl = customLinkFilter(superUrl, comboBox1.Text, textBox2.Text, comboBox2.Text);
            }
            Task startSearch = Task.Run(delegate { var = Searcher.searchMedia(superUrl, downloadFolder); });

            await Task.Delay(TimeSpan.FromSeconds(5));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Searcher.quitDriver();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void User_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (User.Checked == true)
            {
                textBox2.Text = "u/";
                textBox1.Enabled = true;
                Subreddit.Enabled = false;
                Random.Enabled = false;
            }
            else if (User.Checked == false)
            {
                textBox2.Text = "Subreddit or User";
                textBox1.Enabled = false; // prevents user from writing random shit
                Subreddit.Enabled = true;
                Random.Enabled = true;
            }

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Subreddit.Checked == true)
            {
                textBox2.Text = "r/";
                textBox1.Enabled = true;
                User.Enabled = false;
                Random.Enabled = false;
            }
            else if (Subreddit.Checked == false)
            {

                textBox2.Text = "Subreddit or User";
                textBox1.Enabled = false; // prevents user from writing random shti
                User.Enabled = true;
                Random.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (Random.Checked == true)
            {
                textBox1.Enabled = false;
                User.Enabled = false;
                Subreddit.Enabled = false;
            }
            else if (Random.Checked == false)
            {
                textBox1.Enabled = true;
                User.Enabled = true;
                Subreddit.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(comboBox1.Text == "Top" || comboBox1.Text == "Rising" || comboBox1.Text == "Controversial"))
            {
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private string customLinkFilter(string combinedURl, string sortType, string linkType, string sortTime)
        {
            string newUrl = " ";
            string conjunctionTypeA = "?sort=";
            string conjunctionTypeB = "&sort=";
            string conjunctionTypeATime = "?t=";
            string conjunctionTypeBTime = "&t=";
            if (linkType == "u/")
            {
                switch (sortType)
                {
                    case "Hot":
                        newUrl = combinedURl + conjunctionTypeA + "hot";
                        break;
                    case "Top":
                        newUrl = combinedURl + conjunctionTypeA + "top";
                        if(sortTime == "Past Hour")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "hour";
                        }
                        else if(sortTime == "Past Day")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "day";
                        }
                        else if (sortTime == "Past Week")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "week";
                        }
                        else if (sortTime == "Past Month")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "month";
                        }
                        else if (sortTime == "Past Year")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "year";
                        }
                        else if (sortTime == "All")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "all";
                        }
                        else
                        {
                            return newUrl;
                        }
                        break;
                    case "New":
                        newUrl = combinedURl + conjunctionTypeA + "new";
                        break;
                    default:
                        newUrl = combinedURl;
                        break;
                }
            }
            else if(linkType == "r/")
            {
                switch (sortType)
                {
                    case "Hot":
                        newUrl = combinedURl + conjunctionTypeB + "hot";
                        break;
                    case "Top":
                        newUrl = combinedURl + conjunctionTypeB + "top";
                        if (sortTime == "Past Hour")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "hour";
                        }
                        else if (sortTime == "Past Day")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "day";
                        }
                        else if (sortTime == "Past Week")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "week";
                        }
                        else if (sortTime == "Past Month")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "month";
                        }
                        else if (sortTime == "Past Year")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "year";
                        }
                        else if (sortTime == "All")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "all";
                        }
                        else
                        {
                            return newUrl;
                        }
                        break;
                    case "New":
                        newUrl = combinedURl + conjunctionTypeB + "new";
                        break;
                    case "Rising":
                        newUrl = combinedURl + conjunctionTypeB + "rising";
                        break;
                    case "Controversial":
                        newUrl = combinedURl + conjunctionTypeB + "controversial";
                        if (sortTime == "Past Hour")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "hour";
                        }
                        else if (sortTime == "Past Day")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "day";
                        }
                        else if (sortTime == "Past Week")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "week";
                        }
                        else if (sortTime == "Past Month")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "month";
                        }
                        else if (sortTime == "Past Year")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "year";
                        }
                        else if (sortTime == "All")
                        {
                            newUrl = newUrl + conjunctionTypeBTime + "all";
                        }
                        else
                        {
                            return newUrl;
                        }
                        break;
                    default:
                        newUrl = combinedURl;
                        break;
                }
            }
            return newUrl;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}