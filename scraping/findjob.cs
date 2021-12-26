using System;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace scraping
{
    public partial class findjob : Form
    {
        public findjob()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://djinni.co/jobs";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            HtmlNodeCollection linkNodes = doc.DocumentNode.SelectNodes("//div/a[@class=\"jobs-filter__link\"]");
            foreach (var node in linkNodes)
            {
                if (node.Attributes["href"].Value.Contains("keyword")) //checking is it the part about job title
                {
                    job_title.Items.Add(node.Attributes["href"].Value); //should make a decide use this form or node.InnerText
                }
                if (node.Attributes["href"].Value.Contains("exp_level")) //checking is it the part about work experience
                {
                    work_experience.Items.Add(node.Attributes["href"].Value);
                }
                if (node.Attributes["href"].Value.Contains("remote_type")) //checking is it the part about work style
                {
                    remote_or_office.Items.Add(node.Attributes["href"].Value);
                }
            }
        }

        private void get_Click(object sender, EventArgs e)
        {
            jobs.Clear();
            string url = "https://djinni.co/jobs/";
            string filter1 = "", filter2 = "", filter3 = "";
            try
            {
                filter1 = job_title.Text.Remove(0, 6); //removing the "/jobs" part from the link
            }
            catch { }
            try
            {
                filter2 = work_experience.Text.Remove(0, 7); //removing the "/jobs/" part from the link
            }
            catch { }
            try
            {
                filter3 = remote_or_office.Text.Remove(0, 7); //removing the "/jobs/" part from the link
            }
            catch { }
            if (filter1 != "") url += filter1; //adding the conditions to the link
            url += "?";
            if (filter2 != "") url += filter2;
            url += "&";
            if (filter3 != "") url += filter3;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            //jobs.Text = url + "\n";
            HtmlNode node = null;
            node = doc.DocumentNode.SelectSingleNode("//div[@class='container']/div[@class='page-header']/h1/span[@class='text-muted']"); //to find how many job there is
            int number_of_jobs = Convert.ToInt32(node.InnerText);
            int number_of_pages = (int)Math.Ceiling((double)(number_of_jobs) / 15);
            HtmlNodeCollection linkNodes = doc.DocumentNode.SelectNodes("//li[@class='list-jobs__item']/div[@class='list-jobs__title']/a[@class='profile']/span");
            foreach (var obj in linkNodes)
            {
                jobs.Text += obj.InnerText + "\n";
            }
            //jobs.Text += number_of_pages;
            for (int i = 2; i < number_of_pages; i++)
            {
                url += "&page=" + i; //adding the page number to the end of the link
                doc = web.Load(url);
                linkNodes = doc.DocumentNode.SelectNodes("//li[@class='list-jobs__item']/div[@class='list-jobs__title']/a[@class='profile']/span");
                foreach (var obj in linkNodes)
                {
                    jobs.Text += obj.InnerText + "\n";
                }
            }
        }
    }
}
