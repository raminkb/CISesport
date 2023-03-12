namespace CISesport
{
    public partial class FormInfo : Form
    {
        private Player _newPlayer;
        public FormInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string lastname = textBoxLName.Text;
            string studentid = textBoxID.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxtelphone.Text;
            string displayname = textBoxGName.Text;
            string major = textBoxMajor.Text;
            int iage = 0;
            try
            {
                string age = textBoxAge.Text;
                iage = Int32.Parse(age);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ใส่ไม่ถูกต้อง");
                return;
            }
            _newPlayer = new Player(name,lastname,studentid,major,email,phone,displayname,iage);
            this.DialogResult = DialogResult.OK;
        } 
        public Player getPlayer() { return _newPlayer; }
    }
}