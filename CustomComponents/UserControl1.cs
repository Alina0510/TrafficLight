namespace CustomComponents
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Thread thread = new Thread(StartLight);
            thread.Start();
        }
    }
}