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

        private void btnAddList_Click(object sender, EventArgs e)
        {
            FrmTaskList taskList = new FrmTaskList();

            if (taskList.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show($"Neue TaskList: {taskList.TaskList.ToString()}");
                _taskLists.Add(taskList.TaskList);
                UpdateTaskListBox();
            }
        }

        private void UpdateTaskListBox()
        {
            lstBoxTaskLists.Items.Clear();
            foreach (TaskList taskList in _taskLists)
            {
                lstBoxTaskLists.Items.Add(taskList.ToString());
            }
        }

        private void lstBoxTaskLists_DoubleClick(object sender, EventArgs e)
        {
            if (lstBoxTaskLists.SelectedIndex < 0) return;

            FrmTaskList frmTaskList = new FrmTaskList();
            frmTaskList.TaskList = _taskLists.ElementAt(lstBoxTaskLists.SelectedIndex);

            if(frmTaskList.ShowDialog() == DialogResult.OK)
            {
                UpdateTaskListBox();
            }
        }
    }
}
