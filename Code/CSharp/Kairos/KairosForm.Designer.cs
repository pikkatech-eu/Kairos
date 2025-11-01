namespace Kairos
{
	partial class KairosForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KairosForm));
			this.menuStrip1 = new MenuStrip();
			this.collectionToolStripMenuItem = new ToolStripMenuItem();
			this.newToolStripMenuItem = new ToolStripMenuItem();
			this.editToolStripMenuItem = new ToolStripMenuItem();
			this.loadToolStripMenuItem = new ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.quitToolStripMenuItem = new ToolStripMenuItem();
			this.projectToolStripMenuItem = new ToolStripMenuItem();
			this.newToolStripMenuItem1 = new ToolStripMenuItem();
			this.editToolStripMenuItem1 = new ToolStripMenuItem();
			this.deleteToolStripMenuItem = new ToolStripMenuItem();
			this.activityToolStripMenuItem = new ToolStripMenuItem();
			this.newToolStripMenuItem2 = new ToolStripMenuItem();
			this.editToolStripMenuItem2 = new ToolStripMenuItem();
			this.deleteToolStripMenuItem1 = new ToolStripMenuItem();
			this.toolsToolStripMenuItem = new ToolStripMenuItem();
			this.settingsToolStripMenuItem = new ToolStripMenuItem();
			this.helpToolStripMenuItem = new ToolStripMenuItem();
			this.aboutToolStripMenuItem = new ToolStripMenuItem();
			this.toolStrip1 = new ToolStrip();
			this.toolStripButton1 = new ToolStripButton();
			this.toolStripButton2 = new ToolStripButton();
			this.toolStripButton4 = new ToolStripButton();
			this.toolStripButton5 = new ToolStripButton();
			this.toolStripButton6 = new ToolStripButton();
			this.toolStripSeparator6 = new ToolStripSeparator();
			this.toolStripButton3 = new ToolStripButton();
			this._lblProject = new ToolStripLabel();
			this._lblCollection = new ToolStripLabel();
			this._btStart = new ToolStripButton();
			this._btStop = new ToolStripButton();
			this.toolStripSeparator5 = new ToolStripSeparator();
			this.statusStrip1 = new StatusStrip();
			this._lblCurrentSumForItem = new ToolStripStatusLabel();
			this._lblCurrentSumForTime = new ToolStripStatusLabel();
			this._scKairos = new SplitContainer();
			this._tvProjects = new TreeView();
			this._cmsProject = new ContextMenuStrip(this.components);
			this.editProjectToolStripMenuItem = new ToolStripMenuItem();
			this.deleteProjectToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.addToolStripMenuItem = new ToolStripMenuItem();
			this._ilIssues = new ImageList(this.components);
			this._lvActivities = new ListView();
			this.Start = new ColumnHeader();
			this.Finish = new ColumnHeader();
			this.Duration = new ColumnHeader();
			this.Comment = new ColumnHeader();
			this._cmsWorkInterval = new ContextMenuStrip(this.components);
			this.lToolStripMenuItem = new ToolStripMenuItem();
			this.deleteWorkIntervaToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this._cmsActivity = new ContextMenuStrip(this.components);
			this.editActivityToolStripMenuItem = new ToolStripMenuItem();
			this.deleteActivityToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.aToolStripMenuItem = new ToolStripMenuItem();
			this.startToolStripMenuItem = new ToolStripMenuItem();
			this.stopToolStripMenuItem = new ToolStripMenuItem();
			this._timerSecond = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this._scKairos).BeginInit();
			this._scKairos.Panel1.SuspendLayout();
			this._scKairos.Panel2.SuspendLayout();
			this._scKairos.SuspendLayout();
			this._cmsProject.SuspendLayout();
			this._cmsWorkInterval.SuspendLayout();
			this._cmsActivity.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new Font("Consolas", 12F);
			this.menuStrip1.ImageScalingSize = new Size(20, 20);
			this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.collectionToolStripMenuItem, this.projectToolStripMenuItem, this.activityToolStripMenuItem, this.toolsToolStripMenuItem, this.helpToolStripMenuItem });
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(1144, 31);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// collectionToolStripMenuItem
			// 
			this.collectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.newToolStripMenuItem, this.editToolStripMenuItem, this.loadToolStripMenuItem, this.saveAsToolStripMenuItem, this.toolStripSeparator1, this.quitToolStripMenuItem });
			this.collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
			this.collectionToolStripMenuItem.Size = new Size(134, 27);
			this.collectionToolStripMenuItem.Text = "&Collection";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
			this.newToolStripMenuItem.Size = new Size(224, 28);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.ToolTipText = "Creates a new project collection from file";
			this.newToolStripMenuItem.Click += this.OnCollectionNew;
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new Size(224, 28);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.ToolTipText = "Edits currently loaded project collection";
			this.editToolStripMenuItem.Click += this.OnCollectionEdit;
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new Size(224, 28);
			this.loadToolStripMenuItem.Text = "&Load";
			this.loadToolStripMenuItem.ToolTipText = "Loads a project collection";
			this.loadToolStripMenuItem.Click += this.OnProjectCollectionLoad;
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new Size(224, 28);
			this.saveAsToolStripMenuItem.Text = "Save &As";
			this.saveAsToolStripMenuItem.ToolTipText = "Saves the current project collection under a new file name";
			this.saveAsToolStripMenuItem.Click += this.OnProjectCollectionSaveAs;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(221, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new Size(224, 28);
			this.quitToolStripMenuItem.Text = "&Quit";
			this.quitToolStripMenuItem.ToolTipText = "Quits the program";
			this.quitToolStripMenuItem.Click += this.OnProjectCollectionQuit;
			// 
			// projectToolStripMenuItem
			// 
			this.projectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.newToolStripMenuItem1, this.editToolStripMenuItem1, this.deleteToolStripMenuItem });
			this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
			this.projectToolStripMenuItem.Size = new Size(101, 27);
			this.projectToolStripMenuItem.Text = "&Project";
			// 
			// newToolStripMenuItem1
			// 
			this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
			this.newToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
			this.newToolStripMenuItem1.Size = new Size(269, 28);
			this.newToolStripMenuItem1.Text = "&New";
			this.newToolStripMenuItem1.ToolTipText = "Adds a new project to the currenty project collection";
			this.newToolStripMenuItem1.Click += this.OnProjectNew;
			// 
			// editToolStripMenuItem1
			// 
			this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
			this.editToolStripMenuItem1.Size = new Size(269, 28);
			this.editToolStripMenuItem1.Text = "&Edit";
			this.editToolStripMenuItem1.ToolTipText = "Edits the properties of the selected project";
			this.editToolStripMenuItem1.Click += this.OnProjectEdit;
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new Size(269, 28);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.ToolTipText = "Deletes selected project from the project collection";
			this.deleteToolStripMenuItem.Click += this.OnProjectDelete;
			// 
			// activityToolStripMenuItem
			// 
			this.activityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.newToolStripMenuItem2, this.editToolStripMenuItem2, this.deleteToolStripMenuItem1 });
			this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
			this.activityToolStripMenuItem.Size = new Size(112, 27);
			this.activityToolStripMenuItem.Text = "&Activity";
			// 
			// newToolStripMenuItem2
			// 
			this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
			this.newToolStripMenuItem2.Size = new Size(160, 28);
			this.newToolStripMenuItem2.Text = "&New";
			this.newToolStripMenuItem2.ToolTipText = "Adds a new activity to selected project";
			this.newToolStripMenuItem2.Click += this.OnActivityNew;
			// 
			// editToolStripMenuItem2
			// 
			this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
			this.editToolStripMenuItem2.Size = new Size(160, 28);
			this.editToolStripMenuItem2.Text = "&Edit";
			this.editToolStripMenuItem2.ToolTipText = "Edits the properties of selected activity";
			this.editToolStripMenuItem2.Click += this.OnActivityEdit;
			// 
			// deleteToolStripMenuItem1
			// 
			this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			this.deleteToolStripMenuItem1.Size = new Size(160, 28);
			this.deleteToolStripMenuItem1.Text = "&Delete";
			this.deleteToolStripMenuItem1.ToolTipText = "Deletes selected activity";
			this.deleteToolStripMenuItem1.Click += this.OnActivityDelete;
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.settingsToolStripMenuItem });
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new Size(79, 27);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new Size(182, 28);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.ToolTipText = "Calls the settings dialog";
			this.settingsToolStripMenuItem.Click += this.OnToolsSettings;
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.aboutToolStripMenuItem });
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new Size(68, 27);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new Size(224, 28);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.ToolTipText = "Calls the About dialog";
			this.aboutToolStripMenuItem.Click += this.OnHelpAbout;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.Font = new Font("Consolas", 10F);
			this.toolStrip1.ImageScalingSize = new Size(20, 20);
			this.toolStrip1.Items.AddRange(new ToolStripItem[] { this.toolStripButton1, this.toolStripButton2, this.toolStripButton4, this.toolStripButton5, this.toolStripButton6, this.toolStripSeparator6, this.toolStripButton3, this._lblProject, this._lblCollection, this._btStart, this._btStop, this.toolStripSeparator5 });
			this.toolStrip1.Location = new Point(0, 31);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new Size(1144, 40);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = Properties.Resources.Load;
			this.toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
			this.toolStripButton1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new Size(34, 37);
			this.toolStripButton1.ToolTipText = "Opens a project collection from file";
			this.toolStripButton1.Click += this.OnProjectCollectionLoad;
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = Properties.Resources.Save;
			this.toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
			this.toolStripButton2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new Size(34, 37);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.ToolTipText = "Saves the current project collection under a new file name";
			this.toolStripButton2.Click += this.OnProjectCollectionSaveAs;
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = Properties.Resources.rocket_green_32;
			this.toolStripButton4.ImageScaling = ToolStripItemImageScaling.None;
			this.toolStripButton4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new Size(36, 37);
			this.toolStripButton4.Text = "toolStripButton4";
			this.toolStripButton4.ToolTipText = "Adds a new project to the currenty project collection";
			this.toolStripButton4.Click += this.OnProjectNew;
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = Properties.Resources.target_green_32;
			this.toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
			this.toolStripButton5.ImageTransparentColor = Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new Size(36, 37);
			this.toolStripButton5.Text = "toolStripButton5";
			this.toolStripButton5.ToolTipText = "Adds a new activity to selected project";
			this.toolStripButton5.Click += this.OnActivityNew;
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Image = Properties.Resources.Settings;
			this.toolStripButton6.ImageScaling = ToolStripItemImageScaling.None;
			this.toolStripButton6.ImageTransparentColor = Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new Size(34, 37);
			this.toolStripButton6.Text = "toolStripButton6";
			this.toolStripButton6.ToolTipText = "Calls the settings dialog";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new Size(6, 40);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.Alignment = ToolStripItemAlignment.Right;
			this.toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = Properties.Resources.Quit;
			this.toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
			this.toolStripButton3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new Size(34, 37);
			this.toolStripButton3.Text = "toolStripButton3";
			this.toolStripButton3.ToolTipText = "Quits the program";
			this.toolStripButton3.Click += this.OnProjectCollectionQuit;
			// 
			// _lblProject
			// 
			this._lblProject.Alignment = ToolStripItemAlignment.Right;
			this._lblProject.Font = new Font("Consolas", 14F);
			this._lblProject.ForeColor = Color.ForestGreen;
			this._lblProject.Name = "_lblProject";
			this._lblProject.Size = new Size(142, 37);
			this._lblProject.Text = "Project...";
			// 
			// _lblCollection
			// 
			this._lblCollection.Alignment = ToolStripItemAlignment.Right;
			this._lblCollection.Font = new Font("Consolas", 14F);
			this._lblCollection.ForeColor = Color.MediumBlue;
			this._lblCollection.Name = "_lblCollection";
			this._lblCollection.Size = new Size(181, 37);
			this._lblCollection.Text = "Collection...";
			// 
			// _btStart
			// 
			this._btStart.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._btStart.Image = Properties.Resources.Start;
			this._btStart.ImageScaling = ToolStripItemImageScaling.None;
			this._btStart.ImageTransparentColor = Color.Magenta;
			this._btStart.Name = "_btStart";
			this._btStart.Size = new Size(34, 37);
			this._btStart.TextImageRelation = TextImageRelation.Overlay;
			this._btStart.ToolTipText = "Start new activity";
			this._btStart.Click += this.OnActivityStartWorkInterval;
			// 
			// _btStop
			// 
			this._btStop.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._btStop.Image = Properties.Resources.Stop;
			this._btStop.ImageScaling = ToolStripItemImageScaling.None;
			this._btStop.ImageTransparentColor = Color.Magenta;
			this._btStop.Name = "_btStop";
			this._btStop.Size = new Size(34, 37);
			this._btStop.Text = "toolStripButton1";
			this._btStop.ToolTipText = "Stop running activity";
			this._btStop.Click += this.OnActivityStopWorkInterval;
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new Size(6, 40);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Font = new Font("Consolas", 14F);
			this.statusStrip1.ImageScalingSize = new Size(20, 20);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] { this._lblCurrentSumForItem, this._lblCurrentSumForTime });
			this.statusStrip1.Location = new Point(0, 719);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(1144, 34);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// _lblCurrentSumForItem
			// 
			this._lblCurrentSumForItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			this._lblCurrentSumForItem.Name = "_lblCurrentSumForItem";
			this._lblCurrentSumForItem.Size = new Size(36, 28);
			this._lblCurrentSumForItem.Text = "***";
			// 
			// _lblCurrentSumForTime
			// 
			this._lblCurrentSumForTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			this._lblCurrentSumForTime.ForeColor = Color.MediumBlue;
			this._lblCurrentSumForTime.Name = "_lblCurrentSumForTime";
			this._lblCurrentSumForTime.Size = new Size(36, 28);
			this._lblCurrentSumForTime.Text = "***";
			// 
			// _scKairos
			// 
			this._scKairos.Dock = DockStyle.Fill;
			this._scKairos.Location = new Point(0, 71);
			this._scKairos.Name = "_scKairos";
			// 
			// _scKairos.Panel1
			// 
			this._scKairos.Panel1.Controls.Add(this._tvProjects);
			// 
			// _scKairos.Panel2
			// 
			this._scKairos.Panel2.Controls.Add(this._lvActivities);
			this._scKairos.Size = new Size(1144, 648);
			this._scKairos.SplitterDistance = 380;
			this._scKairos.TabIndex = 3;
			// 
			// _tvProjects
			// 
			this._tvProjects.ContextMenuStrip = this._cmsProject;
			this._tvProjects.Dock = DockStyle.Fill;
			this._tvProjects.ImageIndex = 0;
			this._tvProjects.ImageList = this._ilIssues;
			this._tvProjects.Location = new Point(0, 0);
			this._tvProjects.Name = "_tvProjects";
			this._tvProjects.SelectedImageIndex = 0;
			this._tvProjects.Size = new Size(380, 648);
			this._tvProjects.TabIndex = 0;
			this._tvProjects.AfterSelect += this.OnNodeSelected;
			// 
			// _cmsProject
			// 
			this._cmsProject.Font = new Font("Consolas", 10F);
			this._cmsProject.ImageScalingSize = new Size(20, 20);
			this._cmsProject.Items.AddRange(new ToolStripItem[] { this.editProjectToolStripMenuItem, this.deleteProjectToolStripMenuItem, this.toolStripSeparator3, this.addToolStripMenuItem });
			this._cmsProject.Name = "_cmsProject";
			this._cmsProject.Size = new Size(205, 82);
			// 
			// editProjectToolStripMenuItem
			// 
			this.editProjectToolStripMenuItem.Name = "editProjectToolStripMenuItem";
			this.editProjectToolStripMenuItem.Size = new Size(210, 24);
			this.editProjectToolStripMenuItem.Text = "&Edit Project";
			this.editProjectToolStripMenuItem.ToolTipText = "Edits currently loaded project collection";
			this.editProjectToolStripMenuItem.Click += this.OnProjectEdit;
			// 
			// deleteProjectToolStripMenuItem
			// 
			this.deleteProjectToolStripMenuItem.Name = "deleteProjectToolStripMenuItem";
			this.deleteProjectToolStripMenuItem.Size = new Size(210, 24);
			this.deleteProjectToolStripMenuItem.Text = "&Delete Project";
			this.deleteProjectToolStripMenuItem.ToolTipText = "Deletes selected project from the project collection";
			this.deleteProjectToolStripMenuItem.Click += this.OnProjectDelete;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size(201, 6);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new Size(204, 24);
			this.addToolStripMenuItem.Text = "Add &Activity";
			this.addToolStripMenuItem.ToolTipText = "Adds a new activity to selected project";
			this.addToolStripMenuItem.Click += this.OnActivityNew;
			// 
			// _ilIssues
			// 
			this._ilIssues.ColorDepth = ColorDepth.Depth32Bit;
			this._ilIssues.ImageStream = (ImageListStreamer)resources.GetObject("_ilIssues.ImageStream");
			this._ilIssues.TransparentColor = Color.Transparent;
			this._ilIssues.Images.SetKeyName(0, "bug_major");
			this._ilIssues.Images.SetKeyName(1, "bug_minor");
			this._ilIssues.Images.SetKeyName(2, "feature");
			this._ilIssues.Images.SetKeyName(3, "rocket");
			this._ilIssues.Images.SetKeyName(4, "target");
			// 
			// _lvActivities
			// 
			this._lvActivities.Columns.AddRange(new ColumnHeader[] { this.Start, this.Finish, this.Duration, this.Comment });
			this._lvActivities.ContextMenuStrip = this._cmsWorkInterval;
			this._lvActivities.Dock = DockStyle.Fill;
			this._lvActivities.FullRowSelect = true;
			this._lvActivities.Location = new Point(0, 0);
			this._lvActivities.Name = "_lvActivities";
			this._lvActivities.Size = new Size(760, 648);
			this._lvActivities.TabIndex = 0;
			this._lvActivities.UseCompatibleStateImageBehavior = false;
			this._lvActivities.View = View.Details;
			this._lvActivities.SelectedIndexChanged += this.OnWorkIntervalSelected;
			// 
			// Start
			// 
			this.Start.Text = "Start";
			// 
			// Finish
			// 
			this.Finish.Text = "Finish";
			// 
			// Duration
			// 
			this.Duration.Text = "Duration";
			// 
			// Comment
			// 
			this.Comment.Text = "Comment";
			// 
			// _cmsWorkInterval
			// 
			this._cmsWorkInterval.Font = new Font("Consolas", 10F);
			this._cmsWorkInterval.ImageScalingSize = new Size(20, 20);
			this._cmsWorkInterval.Items.AddRange(new ToolStripItem[] { this.lToolStripMenuItem, this.deleteWorkIntervaToolStripMenuItem, this.toolStripSeparator2 });
			this._cmsWorkInterval.Name = "_cmsWorkInterval";
			this._cmsWorkInterval.Size = new Size(259, 58);
			// 
			// lToolStripMenuItem
			// 
			this.lToolStripMenuItem.Name = "lToolStripMenuItem";
			this.lToolStripMenuItem.Size = new Size(258, 24);
			this.lToolStripMenuItem.Text = "&Edit Work interval";
			this.lToolStripMenuItem.ToolTipText = "Edits selected work interval";
			this.lToolStripMenuItem.Click += this.OnWorkIntervalEdit;
			// 
			// deleteWorkIntervaToolStripMenuItem
			// 
			this.deleteWorkIntervaToolStripMenuItem.Name = "deleteWorkIntervaToolStripMenuItem";
			this.deleteWorkIntervaToolStripMenuItem.Size = new Size(258, 24);
			this.deleteWorkIntervaToolStripMenuItem.Text = "&Delete Work interval";
			this.deleteWorkIntervaToolStripMenuItem.ToolTipText = "Deletes selected work interval";
			this.deleteWorkIntervaToolStripMenuItem.Click += this.OnWorkIntervalDelete;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(255, 6);
			// 
			// _cmsActivity
			// 
			this._cmsActivity.Font = new Font("Consolas", 10F);
			this._cmsActivity.ImageScalingSize = new Size(20, 20);
			this._cmsActivity.Items.AddRange(new ToolStripItem[] { this.editActivityToolStripMenuItem, this.deleteActivityToolStripMenuItem, this.toolStripSeparator4, this.aToolStripMenuItem, this.startToolStripMenuItem, this.stopToolStripMenuItem });
			this._cmsActivity.Name = "_cmsActivity";
			this._cmsActivity.Size = new Size(349, 130);
			// 
			// editActivityToolStripMenuItem
			// 
			this.editActivityToolStripMenuItem.Name = "editActivityToolStripMenuItem";
			this.editActivityToolStripMenuItem.Size = new Size(348, 24);
			this.editActivityToolStripMenuItem.Text = "&Edit Activity";
			this.editActivityToolStripMenuItem.ToolTipText = "Edits the properties of selected activity";
			this.editActivityToolStripMenuItem.Click += this.OnActivityEdit;
			// 
			// deleteActivityToolStripMenuItem
			// 
			this.deleteActivityToolStripMenuItem.Name = "deleteActivityToolStripMenuItem";
			this.deleteActivityToolStripMenuItem.Size = new Size(348, 24);
			this.deleteActivityToolStripMenuItem.Text = "&Delete Activity";
			this.deleteActivityToolStripMenuItem.ToolTipText = "Deletes selected activity";
			this.deleteActivityToolStripMenuItem.Click += this.OnActivityDelete;
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new Size(345, 6);
			// 
			// aToolStripMenuItem
			// 
			this.aToolStripMenuItem.Name = "aToolStripMenuItem";
			this.aToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.A;
			this.aToolStripMenuItem.Size = new Size(348, 24);
			this.aToolStripMenuItem.Text = "Add &Work Interval";
			this.aToolStripMenuItem.ToolTipText = "Adds a new work interval from GUI";
			this.aToolStripMenuItem.Click += this.OnActivityAddWorkInterval;
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			this.startToolStripMenuItem.ShortcutKeys = Keys.F5;
			this.startToolStripMenuItem.Size = new Size(348, 24);
			this.startToolStripMenuItem.Text = "&Start Work Interval";
			this.startToolStripMenuItem.ToolTipText = "Sarts a work interval";
			this.startToolStripMenuItem.Click += this.OnActivityStartWorkInterval;
			// 
			// stopToolStripMenuItem
			// 
			this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
			this.stopToolStripMenuItem.ShortcutKeys = Keys.F6;
			this.stopToolStripMenuItem.Size = new Size(348, 24);
			this.stopToolStripMenuItem.Text = "&Stop Work Interval";
			this.stopToolStripMenuItem.ToolTipText = "Stops current work interval";
			this.stopToolStripMenuItem.Click += this.OnActivityStopWorkInterval;
			// 
			// _timerSecond
			// 
			this._timerSecond.Interval = 1000;
			// 
			// KairosForm
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(1144, 753);
			this.Controls.Add(this._scKairos);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new Font("Consolas", 10F);
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "KairosForm";
			this.Text = "Kairos 1.0";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this._scKairos.Panel1.ResumeLayout(false);
			this._scKairos.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this._scKairos).EndInit();
			this._scKairos.ResumeLayout(false);
			this._cmsProject.ResumeLayout(false);
			this._cmsWorkInterval.ResumeLayout(false);
			this._cmsActivity.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStrip toolStrip1;
		private StatusStrip statusStrip1;
		private ToolStripMenuItem collectionToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem loadToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem quitToolStripMenuItem;
		private ToolStripMenuItem projectToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem1;
		private ToolStripMenuItem editToolStripMenuItem1;
		private ToolStripMenuItem deleteToolStripMenuItem;
		private ToolStripMenuItem activityToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem2;
		private ToolStripMenuItem editToolStripMenuItem2;
		private ToolStripMenuItem deleteToolStripMenuItem1;
		private ToolStripMenuItem toolsToolStripMenuItem;
		private ToolStripMenuItem settingsToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private ToolStripStatusLabel _lblCurrentSumForItem;
		private SplitContainer _scKairos;
		private TreeView _tvProjects;
		private ListView _lvActivities;
		private ToolStripLabel _lblCollection;
		private ToolStripLabel _lblProject;
		private ToolStripButton _btStart;
		private ToolStripButton _btStop;
		private ContextMenuStrip _cmsProject;
		private ToolStripMenuItem editProjectToolStripMenuItem;
		private ToolStripMenuItem deleteProjectToolStripMenuItem;
		private ContextMenuStrip _cmsActivity;
		private ToolStripMenuItem editActivityToolStripMenuItem;
		private ToolStripMenuItem deleteActivityToolStripMenuItem;
		private ContextMenuStrip _cmsWorkInterval;
		private ToolStripMenuItem lToolStripMenuItem;
		private ToolStripMenuItem deleteWorkIntervaToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem addToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripMenuItem aToolStripMenuItem;
		private ToolStripMenuItem startToolStripMenuItem;
		private ToolStripMenuItem stopToolStripMenuItem;
		private ColumnHeader Start;
		private ColumnHeader Finish;
		private ColumnHeader Duration;
		private ColumnHeader Comment;
		private ToolStripStatusLabel _lblCurrentSumForTime;
		private System.Windows.Forms.Timer _timerSecond;
		private ImageList _ilIssues;
		private ToolStripButton toolStripButton1;
		private ToolStripButton toolStripButton2;
		private ToolStripButton toolStripButton3;
		private ToolStripSeparator toolStripSeparator5;
		private ToolStripButton toolStripButton4;
		private ToolStripButton toolStripButton5;
		private ToolStripButton toolStripButton6;
		private ToolStripSeparator toolStripSeparator6;
	}
}
