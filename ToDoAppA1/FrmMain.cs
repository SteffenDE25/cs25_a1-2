namespace ToDoAppA1
{
    public partial class FrmMain : Form
    {
        private List<TaskList> _taskLists;
        public FrmMain()
        {
            InitializeComponent();
            _taskLists = new List<TaskList>();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
