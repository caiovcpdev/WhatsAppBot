namespace WhatsAppBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WhastAppSendMessage w = new WhastAppSendMessage();
            //w.SendImage("Teste bot", "C:\\Users\\caio\\Downloads\\teste-image.jfif", "@testebot");
            //w.SendMessage("Teste bot", "@testebot");
            w.SendEmoji("Teste bot", new List<string> { "robo" }, "@testebot");
        }
    }
}