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
			KairosManager.Instance.CurrentWorkIntervalChanged += this.OnCurrentWorkIntervalChanged;
		}

		private void OnCurrentWorkIntervalChanged(WorkInterval workInterval)
		{
			this._txStartTime.Text = workInterval.Start.ToString();
			this._txCurrentTime.Text	= workInterval.End.ToString();
			this._txDuration.Text	= workInterval.Duration.StripMilliseconds().ToString();
		}

		private void OnSelectedActivityChanged(Activity activity)
		{
			this.UpdateActivityListView(activity);
		}

		private void UpdateActivityListView(Activity activity)
		{
			this._lvActivities.Items.Clear();

			foreach (WorkInterval workInterval in activity.WorkIntervals)
			{
				string[] itemStrings = workInterval.ListViewStrings();

				ListViewItem lvi = new ListViewItem(itemStrings);

				lvi.Tag = workInterval;

				this._lvActivities.Items.Add(lvi);
			}

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
			}
		}

		private void OnActivityNew(object sender, EventArgs e)
		{
			if (this._tvProjects.SelectedNode != null && this._tvProjects.SelectedNode.Tag is Project)
			{
				Project project = this._tvProjects.SelectedNode.Tag as Project;

				KairosManager.Instance.AddActivity(project);
			}
		}

		private void OnActivityAddWorkInterval(object sender, EventArgs e)
		{
			if (this._tvProjects.SelectedNode != null && this._tvProjects.SelectedNode.Tag is Activity)
			{
				Activity activity = this._tvProjects.SelectedNode.Tag as Activity;

				KairosManager.Instance.AddAddWorkInterval(activity);
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
	}
}
