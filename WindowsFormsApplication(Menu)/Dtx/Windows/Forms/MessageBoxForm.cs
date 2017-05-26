namespace Dtx.Windows.Forms
{
    public partial class MessageBoxForm : System.Windows.Forms.Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        public string Message { get;set; }

        private void MessageBoxForm_Load(object sender, System.EventArgs e)
        {
            textLable.Text = Message;
        }

    }
}
