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
			this._lblCollection = new ToolStripLabel();
			this._lblProject = new ToolStripLabel();
			this._btStart = new ToolStripButton();
			this._btStop = new ToolStripButton();
			this.statusStrip1 = new StatusStrip();
			this._lvlCurrentSum = new ToolStripStatusLabel();
			this._scKairos = new SplitContainer();
			this._tvProjects = new TreeView();
			this._cmsProject = new ContextMenuStrip(this.components);
			this.editProjectToolStripMenuItem = new ToolStripMenuItem();
			this.deleteProjectToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.addToolStripMenuItem = new ToolStripMenuItem();
			this._lvActivities = new ListView();
			this.Start = new ColumnHeader();
			this.Finish = new ColumnHeader();
			this.Duration = new ColumnHeader();
			this.Comment = new ColumnHeader();
			this._cmsActivity = new ContextMenuStrip(this.components);
			this.editActivityToolStripMenuItem = new ToolStripMenuItem();
			this.deleteActivityToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.aToolStripMenuItem = new ToolStripMenuItem();
			this.startToolStripMenuItem = new ToolStripMenuItem();
			this.stopToolStripMenuItem = new ToolStripMenuItem();
			this._cmsWorkInterval = new ContextMenuStrip(this.components);
			this.lToolStripMenuItem = new ToolStripMenuItem();
			this.deleteWorkIntervaToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this._scKairos).BeginInit();
			this._scKairos.Panel1.SuspendLayout();
			this._scKairos.Panel2.SuspendLayout();
			this._scKairos.SuspendLayout();
			this._cmsProject.SuspendLayout();
			this._cmsActivity.SuspendLayout();
			this._cmsWorkInterval.SuspendLayout();
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
			this.newToolStripMenuItem.Size = new Size(203, 28);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += this.OnCollectionNew;
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new Size(203, 28);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new Size(203, 28);
			this.loadToolStripMenuItem.Text = "&Load";
			this.loadToolStripMenuItem.Click += this.OnProjectCollectionLoad;
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new Size(203, 28);
			this.saveAsToolStripMenuItem.Text = "Save &As";
			this.saveAsToolStripMenuItem.Click += this.OnProjectCollectionSaveAs;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(200, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new Size(203, 28);
			this.quitToolStripMenuItem.Text = "&Quit";
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
			this.newToolStripMenuItem1.Click += this.OnProjectNew;
			// 
			// editToolStripMenuItem1
			// 
			this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
			this.editToolStripMenuItem1.Size = new Size(269, 28);
			this.editToolStripMenuItem1.Text = "&Edit";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new Size(269, 28);
			this.deleteToolStripMenuItem.Text = "&Delete";
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
			this.newToolStripMenuItem2.Click += this.OnActivityNew;
			// 
			// editToolStripMenuItem2
			// 
			this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
			this.editToolStripMenuItem2.Size = new Size(160, 28);
			this.editToolStripMenuItem2.Text = "&Edit";
			// 
			// deleteToolStripMenuItem1
			// 
			this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			this.deleteToolStripMenuItem1.Size = new Size(160, 28);
			this.deleteToolStripMenuItem1.Text = "&Delete";
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
			this.aboutToolStripMenuItem.Size = new Size(149, 28);
			this.aboutToolStripMenuItem.Text = "&About";
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.Font = new Font("Consolas", 10F);
			this.toolStrip1.ImageScalingSize = new Size(20, 20);
			this.toolStrip1.Items.AddRange(new ToolStripItem[] { this._lblCollection, this._lblProject, this._btStart, this._btStop });
			this.toolStrip1.Location = new Point(0, 31);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new Size(1144, 31);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// _lblCollection
			// 
			this._lblCollection.Name = "_lblCollection";
			this._lblCollection.Size = new Size(126, 28);
			this._lblCollection.Text = "Collection...";
			// 
			// _lblProject
			// 
			this._lblProject.Name = "_lblProject";
			this._lblProject.Size = new Size(99, 28);
			this._lblProject.Text = "Project...";
			// 
			// _btStart
			// 
			this._btStart.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._btStart.Image = Properties.Resources.Start;
			this._btStart.ImageTransparentColor = Color.Magenta;
			this._btStart.Name = "_btStart";
			this._btStart.Size = new Size(29, 28);
			this._btStart.TextImageRelation = TextImageRelation.Overlay;
			// 
			// _btStop
			// 
			this._btStop.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._btStop.Image = Properties.Resources.Stop;
			this._btStop.ImageTransparentColor = Color.Magenta;
			this._btStop.Name = "_btStop";
			this._btStop.Size = new Size(29, 28);
			this._btStop.Text = "toolStripButton1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Font = new Font("Consolas", 14F);
			this.statusStrip1.ImageScalingSize = new Size(20, 20);
			this.statusStrip1.Items.AddRange(new ToolStripItem[] { this._lvlCurrentSum });
			this.statusStrip1.Location = new Point(0, 719);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(1144, 34);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// _lvlCurrentSum
			// 
			this._lvlCurrentSum.Name = "_lvlCurrentSum";
			this._lvlCurrentSum.Size = new Size(51, 28);
			this._lvlCurrentSum.Text = "***";
			// 
			// _scKairos
			// 
			this._scKairos.Dock = DockStyle.Fill;
			this._scKairos.Location = new Point(0, 62);
			this._scKairos.Name = "_scKairos";
			// 
			// _scKairos.Panel1
			// 
			this._scKairos.Panel1.Controls.Add(this._tvProjects);
			// 
			// _scKairos.Panel2
			// 
			this._scKairos.Panel2.Controls.Add(this._lvActivities);
			this._scKairos.Size = new Size(1144, 657);
			this._scKairos.SplitterDistance = 380;
			this._scKairos.TabIndex = 3;
			// 
			// _tvProjects
			// 
			this._tvProjects.ContextMenuStrip = this._cmsProject;
			this._tvProjects.Dock = DockStyle.Fill;
			this._tvProjects.Location = new Point(0, 0);
			this._tvProjects.Name = "_tvProjects";
			this._tvProjects.Size = new Size(380, 657);
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
			this.editProjectToolStripMenuItem.Size = new Size(204, 24);
			this.editProjectToolStripMenuItem.Text = "&Edit Project";
			// 
			// deleteProjectToolStripMenuItem
			// 
			this.deleteProjectToolStripMenuItem.Name = "deleteProjectToolStripMenuItem";
			this.deleteProjectToolStripMenuItem.Size = new Size(204, 24);
			this.deleteProjectToolStripMenuItem.Text = "&Delete Project";
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
			this.addToolStripMenuItem.Click += this.OnActivityNew;
			// 
			// _lvActivities
			// 
			this._lvActivities.Columns.AddRange(new ColumnHeader[] { this.Start, this.Finish, this.Duration, this.Comment });
			this._lvActivities.Dock = DockStyle.Fill;
			this._lvActivities.FullRowSelect = true;
			this._lvActivities.Location = new Point(0, 0);
			this._lvActivities.Name = "_lvActivities";
			this._lvActivities.Size = new Size(760, 657);
			this._lvActivities.TabIndex = 0;
			this._lvActivities.UseCompatibleStateImageBehavior = false;
			this._lvActivities.View = View.Details;
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
			// 
			// deleteActivityToolStripMenuItem
			// 
			this.deleteActivityToolStripMenuItem.Name = "deleteActivityToolStripMenuItem";
			this.deleteActivityToolStripMenuItem.Size = new Size(348, 24);
			this.deleteActivityToolStripMenuItem.Text = "&Delete Activity";
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
			this.aToolStripMenuItem.Click += this.OnActivityAddWorkInterval;
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			this.startToolStripMenuItem.ShortcutKeys = Keys.F5;
			this.startToolStripMenuItem.Size = new Size(348, 24);
			this.startToolStripMenuItem.Text = "&Start Work Interval";
			this.startToolStripMenuItem.Click += this.OnActivityStartWorkInterval;
			// 
			// stopToolStripMenuItem
			// 
			this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
			this.stopToolStripMenuItem.ShortcutKeys = Keys.F6;
			this.stopToolStripMenuItem.Size = new Size(348, 24);
			this.stopToolStripMenuItem.Text = "&Stop Work Interval";
			this.stopToolStripMenuItem.Click += this.OnActivityStopWorkInterval;
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
			// 
			// deleteWorkIntervaToolStripMenuItem
			// 
			this.deleteWorkIntervaToolStripMenuItem.Name = "deleteWorkIntervaToolStripMenuItem";
			this.deleteWorkIntervaToolStripMenuItem.Size = new Size(258, 24);
			this.deleteWorkIntervaToolStripMenuItem.Text = "&Delete Work interval";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(255, 6);
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
			this._cmsActivity.ResumeLayout(false);
			this._cmsWorkInterval.ResumeLayout(false);
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
		private ToolStripStatusLabel _lvlCurrentSum;
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
	}
}
