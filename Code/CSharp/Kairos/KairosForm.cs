/***********************************************************************************
* File:         KairosForm.cs                                                      *
* Contents:     Class KairosForm                                                   *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-30 20:32                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Kairos.Library;
using Kairos.Library.Entities;
using Kairos.Library.Extensions;

namespace Kairos
{
	public partial class KairosForm : Form
	{
		public KairosForm()
		{
			InitializeComponent();

			KairosManager.Instance.ProjectCollectionChanged += this.OnProjectCollectionChanged;
			KairosManager.Instance.SelectedActivityChanged += this.OnSelectedActivityChanged;

			this._timerSecond.Tick += this.OnTimerSecondTick;

			this._timerSecond.Start();
		}

		private void OnTimerSecondTick(object? sender, EventArgs e)
		{
			TimeSpan ts = KairosManager.Instance.GetTodaysTime().StripMilliseconds();

			this._lblCurrentSumForTime.Text = $"Total working time today: {ts}";
		}

		private void OnSelectedActivityChanged(Activity activity)
		{
			this.UpdateActivityListView(activity);
		}

		private void OnProjectCollectionChanged(ProjectCollection pc)
		{
			this._lblCollection.Text = pc.Name;

			this.UpdateProjectTreeView();

			this.UpdateActivityListView(null);
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
				this._tvProjects.ContextMenuStrip		= this._cmsActivity;
				KairosManager.Instance.CurrentActivity	= e.Node.Tag as Activity;

				this.UpdateActivityListView(KairosManager.Instance.CurrentActivity);
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

		#region Private Auviliary
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

		private void UpdateActivityListView(Activity activity)
		{
			this._lvActivities.Items.Clear();

			if (activity == null)
			{
				return;
			}

			for (int i = 0; i < activity.WorkIntervals.Count; i++)
			{
				WorkInterval workInterval = activity.WorkIntervals[i];

				string[] itemStrings = workInterval.ListViewStrings();

				ListViewItem lvi = new ListViewItem(itemStrings);

				lvi.Tag = workInterval;
				lvi.UseItemStyleForSubItems = false;

				ListViewItem.ListViewSubItemCollection subItems = lvi.SubItems;

				if (KairosManager.Instance.IsIntervalRunning && i == activity.WorkIntervals.Count - 1)
				{
					subItems[1].ForeColor = Color.White;
					subItems[1].BackColor = Color.DarkGreen;
					// subItems[1].Font = new Font(lvi.Font, FontStyle.Bold);

					subItems[2].ForeColor = Color.White;
					subItems[2].BackColor = Color.DarkGreen;
					// subItems[2].Font = new Font(lvi.Font, FontStyle.Bold);
				}

				this._lvActivities.Items.Add(lvi);
			}

			this._lvActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this._lvActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		#endregion
	}
}
