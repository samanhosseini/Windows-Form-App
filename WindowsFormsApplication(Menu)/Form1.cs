namespace WindowsFormsApplication_Menu_
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form2 frm = new Form2();

            frm.ShowDialog();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("hello");
        }
    }
}
