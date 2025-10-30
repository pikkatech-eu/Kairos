using Kairos.Library;
using Kairos.Library.Entities;
using Kairos.Library.Extensions;
using Kairos.Library.Gui.Dialogs;

namespace Kairos
{
	public partial class KairosForm : Form
	{
		public KairosForm()
		{
			InitializeComponent();

			KairosManager.Instance.ProjectCollectionChanged += this.OnProjectCollectionChanged;
			KairosManager.Instance.SelectedActivityChanged += this.OnSelectedActivityChanged;
			// KairosManager.Instance.CurrentWorkIntervalChanged += this.OnCurrentWorkIntervalChanged;
		}

		private void OnCurrentWorkIntervalChanged(WorkInterval workInterval)
		{
			//if (workInterval == null)
			//{
			//	this._txStartTime.Text		= "";
			//	this._txCurrentTime.Text	= "";
			//	this._txDuration.Text		= "";
			//}
			//else
			//{
			//	this._txStartTime.Text		= workInterval.Start.ToString();
			//	this._txCurrentTime.Text	= workInterval.End.ToString();
			//	this._txDuration.Text		= workInterval.Duration.StripMilliseconds().ToString();
			//}
		}

		private void OnSelectedActivityChanged(Activity activity)
		{
			this.UpdateActivityListView(activity);
		}

		private void UpdateActivityListView(Activity activity)
		{
			this._lvActivities.Items.Clear();

			for (int i = 0; i < activity.WorkIntervals.Count; i++)
			{
				WorkInterval workInterval = activity.WorkIntervals[i];

				string[] itemStrings = workInterval.ListViewStrings();

				ListViewItem lvi = new ListViewItem(itemStrings);

				lvi.Tag = workInterval;

				if (i == activity.WorkIntervals.Count - 1)
				{
					lvi.ForeColor = Color.White;
					lvi.BackColor = Color.DarkGreen;
					lvi.Font = new Font(lvi.Font, FontStyle.Bold);
				}

				this._lvActivities.Items.Add(lvi);
			}

			//foreach (WorkInterval workInterval in activity.WorkIntervals)
			//{
			//	string[] itemStrings = workInterval.ListViewStrings();

			//	ListViewItem lvi = new ListViewItem(itemStrings);

			//	lvi.Tag = workInterval;

			//	this._lvActivities.Items.Add(lvi);
			//}

			this._lvActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this._lvActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		private void OnProjectCollectionChanged(ProjectCollection pc)
		{
			this._lblCollection.Text = pc.Name;

			this.UpdateProjectTreeView();
		}

		private void UpdateProjectTreeView()
		{
			this._tvProjects.Nodes.Clear();

			foreach (var project in KairosManager.Instance.ProjectCollection.Projects)
			{
				TreeNode nodeProject = new TreeNode(project.Name);
				nodeProject.Tag = project;

				this._tvProjects.Nodes.Add(nodeProject);

				foreach (var activity in project.Activities)
				{
					TreeNode nodeActivity = new TreeNode(activity.Name);
					nodeActivity.Tag = activity;

					nodeProject.Nodes.Add(nodeActivity);
				}
			}

			this._tvProjects.ExpandAll();
		}

		private void OnCollectionNew(object sender, EventArgs e)
		{
			KairosManager.Instance.CreateProjectCollection();
		}

		private void OnProjectNew(object sender, EventArgs e)
		{
			KairosManager.Instance.AddProject();
		}

		private void OnNodeSelected(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Tag is Project)
			{
				this._tvProjects.ContextMenuStrip = this._cmsProject;

				Project project = e.Node.Tag as Project;

				this._lblProject.Text = project.Name;
			}
			else if (e.Node.Tag is Activity)
			{
				this._tvProjects.ContextMenuStrip = this._cmsActivity;
				KairosManager.Instance.CurrentActivity	= e.Node.Tag as Activity;
			}
		}

		private void OnActivityNew(object sender, EventArgs e)
		{
			if (this._tvProjects.SelectedNode != null && this._tvProjects.SelectedNode.Tag is Project)
			{
				KairosManager.Instance.CurrentProject = this._tvProjects.SelectedNode.Tag as Project;
				KairosManager.Instance.AddActivity();
			}
		}

		private void OnActivityAddWorkInterval(object sender, EventArgs e)
		{
			if (this._tvProjects.SelectedNode != null && this._tvProjects.SelectedNode.Tag is Activity)
			{
				Activity activity = this._tvProjects.SelectedNode.Tag as Activity;

				KairosManager.Instance.CurrentActivity	= activity;
				KairosManager.Instance.AddAddWorkInterval();
			}
		}

		private void OnActivityStartWorkInterval(object sender, EventArgs e)
		{
			if (this._tvProjects.SelectedNode != null && this._tvProjects.SelectedNode.Tag is Activity)
			{
				Activity activity = this._tvProjects.SelectedNode.Tag as Activity;

				KairosManager.Instance.StartCurrentWorkInterval(activity);
			}
		}

		private void OnActivityStopWorkInterval(object sender, EventArgs e)
		{
			KairosManager.Instance.StopCurrentWorkInterval();
		}

		private void OnProjectCollectionSaveAs(object sender, EventArgs e)
		{
			KairosManager.Instance.SaveProjectCollectionAs();
		}

		private void OnProjectCollectionLoad(object sender, EventArgs e)
		{
			KairosManager.Instance.LoadProjectCollection();
		}
	}
}
