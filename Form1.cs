using System.IO;


namespace PhotoGrabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();




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
      
            }
            else if (textBox2.Text == "u/")
            {

                superUrl = "https://www.popular.pics/reddit/u/" + userURL;
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
    }
}