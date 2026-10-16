namespace ToDoAppA1
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            programmToolStripMenuItem = new ToolStripMenuItem();
            beendenToolStripMenuItem = new ToolStripMenuItem();
            lstBoxTaskLists = new ListBox();
            chkLstBoxTasks = new CheckedListBox();
            btnAddList = new Button();
            btnRemoveList = new Button();
            btnAddTask = new Button();
            btnRemoveTask = new Button();
            lblLists = new Label();
            lblTasks = new Label();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(24, 24);
            menuStripMain.Items.AddRange(new ToolStripItem[] { programmToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(978, 33);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            programmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beendenToolStripMenuItem });
            programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            programmToolStripMenuItem.Size = new Size(113, 29);
            programmToolStripMenuItem.Text = "&Programm";
            // 
            // beendenToolStripMenuItem
            // 
            beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            beendenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            beendenToolStripMenuItem.Size = new Size(270, 34);
            beendenToolStripMenuItem.Text = "&Beenden";
            beendenToolStripMenuItem.Click += beendenToolStripMenuItem_Click;
            // 
            // lstBoxTaskLists
            // 
            lstBoxTaskLists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstBoxTaskLists.FormattingEnabled = true;
            lstBoxTaskLists.Location = new Point(39, 114);
            lstBoxTaskLists.Name = "lstBoxTaskLists";
            lstBoxTaskLists.Size = new Size(396, 479);
            lstBoxTaskLists.TabIndex = 1;
            // 
            // chkLstBoxTasks
            // 
            chkLstBoxTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkLstBoxTasks.FormattingEnabled = true;
            chkLstBoxTasks.Location = new Point(482, 113);
            chkLstBoxTasks.Name = "chkLstBoxTasks";
            chkLstBoxTasks.Size = new Size(456, 480);
            chkLstBoxTasks.TabIndex = 2;
            // 
            // btnAddList
            // 
            btnAddList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddList.Location = new Point(39, 624);
            btnAddList.Name = "btnAddList";
            btnAddList.Size = new Size(112, 34);
            btnAddList.TabIndex = 3;
            btnAddList.Text = "Hinzufügen";
            btnAddList.UseVisualStyleBackColor = true;
            // 
            // btnRemoveList
            // 
            btnRemoveList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveList.Location = new Point(323, 624);
            btnRemoveList.Name = "btnRemoveList";
            btnRemoveList.Size = new Size(112, 34);
            btnRemoveList.TabIndex = 4;
            btnRemoveList.Text = "Löschen";
            btnRemoveList.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            btnAddTask.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddTask.Location = new Point(482, 624);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(112, 34);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = "Hinzufügen";
            btnAddTask.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveTask.Location = new Point(826, 624);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(112, 34);
            btnRemoveTask.TabIndex = 6;
            btnRemoveTask.Text = "Löschen";
            btnRemoveTask.UseVisualStyleBackColor = true;
            // 
            // lblLists
            // 
            lblLists.AutoSize = true;
            lblLists.Location = new Point(39, 69);
            lblLists.Name = "lblLists";
            lblLists.Size = new Size(131, 25);
            lblLists.TabIndex = 7;
            lblLists.Text = "Aufgabenlisten";
            // 
            // lblTasks
            // 
            lblTasks.AutoSize = true;
            lblTasks.Location = new Point(482, 69);
            lblTasks.Name = "lblTasks";
            lblTasks.Size = new Size(90, 25);
            lblTasks.TabIndex = 8;
            lblTasks.Text = "Aufgaben";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 694);
            Controls.Add(lblTasks);
            Controls.Add(lblLists);
            Controls.Add(btnRemoveTask);
            Controls.Add(btnAddTask);
            Controls.Add(btnRemoveList);
            Controls.Add(btnAddList);
            Controls.Add(chkLstBoxTasks);
            Controls.Add(lstBoxTaskLists);
            Controls.Add(menuStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStripMain;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LFH ToDoApp A1";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ListBox lstBoxTaskLists;
        private CheckedListBox chkLstBoxTasks;
        private Button btnAddList;
        private Button btnRemoveList;
        private Button btnAddTask;
        private Button btnRemoveTask;
        private Label lblLists;
        private Label lblTasks;
        private ToolStripMenuItem programmToolStripMenuItem;
        private ToolStripMenuItem beendenToolStripMenuItem;
    }
}
