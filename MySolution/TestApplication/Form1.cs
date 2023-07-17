using System.DirectoryServices;
using System.Net;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        List<Character> characters { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void RunSearch_Click(object sender, EventArgs e)
        {
            characters = ApiEngine.SearchCharacters(textSearch.Text);
            var character = characters.First();
            if (characters.Count > 0)
            {
                scrollBar.Minimum = 0;
                scrollBar.Maximum = characters.Count;
                scrollBar_ValueChanged(sender, e);
            }
            else { scrollBar.Minimum = 0; scrollBar.Maximum = 0; }
            
        }

        private void scrollBar_ValueChanged(object sender, EventArgs e)
        {
            var character = characters[scrollBar.Value];
            textName.Text = character.name;
            if (!string.IsNullOrEmpty(character.image))
            {
                var img = WebRequest.CreateHttp(character.image).GetResponse().GetResponseStream();
                pictureBox1.Image = Image.FromStream(img);
            }
        }

    }
}