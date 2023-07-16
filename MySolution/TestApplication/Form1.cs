using System.Net;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunSearch_Click(object sender, EventArgs e)
        {
            var character = ApiEngine.GetCharacter(textSearch.Text);

            textName.Text = character.name;
            var test = new HttpClient();
            var img = WebRequest.CreateHttp(character.image).GetResponse().GetResponseStream();
            pictureBox1.Image = Image.FromStream(img);
        }
    }
}