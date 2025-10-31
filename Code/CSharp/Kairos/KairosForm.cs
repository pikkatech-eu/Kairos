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
using Kairos.Properties;

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

			this._lblCurrentSumForTime.Text = String.Format("Today's total: {0}", ts);
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

			if (KairosManager.Instance.CurrentProject != null)
			{
				this._lblProject.Text = KairosManager.Instance.CurrentProject.Name;
			}
			else
			{
				this._lblProject.Text = "***";
			}
		}

		private void OnCollectionNew(object sender, EventArgs e)
		{
			KairosManager.Instance.CreateProjectCollection();
		}

		private void OnCollectionEdit(object sender, EventArgs e)
		{
			KairosManager.Instance.EditProjectCollection();
		}

		private void OnProjectNew(object sender, EventArgs e)
		{
			KairosManager.Instance.AddProject();
		}

		private void OnProjectEdit(object sender, EventArgs e)
		{
			KairosManager.Instance.EditProject();
		}

		private void OnProjectDelete(object sender, EventArgs e)
		{
			KairosManager.Instance.DeleteProject();
		}

		private void OnNodeSelected(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Tag is Project)
			{
				this._tvProjects.ContextMenuStrip = this._cmsProject;

				KairosManager.Instance.CurrentProject = e.Node.Tag as Project;
				this._lblProject.Text = KairosManager.Instance.CurrentProject.Name;

				TimeSpan tsToDay = KairosManager.Instance.CurrentProject.GetTodaysTime().StripMilliseconds();
				TimeSpan tsThisWeek = KairosManager.Instance.CurrentProject.GetThisWeeksTime().StripMilliseconds();
				TimeSpan tsTotal = KairosManager.Instance.CurrentProject.GetAllTime().StripMilliseconds();

				this._lblCurrentSumForItem.Text = String.Format
																(
																	Resources.ItemWorkoutValues,
																	KairosManager.Instance.CurrentProject.Name,
																	tsToDay,
																	tsThisWeek,
																	tsTotal
																);
			}

			else if (e.Node.Tag is Activity)
			{
				this._tvProjects.ContextMenuStrip = this._cmsActivity;
				KairosManager.Instance.CurrentActivity = e.Node.Tag as Activity;

				this.UpdateActivityListView(KairosManager.Instance.CurrentActivity);

				TimeSpan tsToDay = KairosManager.Instance.CurrentActivity.GetTodaysTime().StripMilliseconds();
				TimeSpan tsThisWeek = KairosManager.Instance.CurrentActivity.GetThisWeeksTime().StripMilliseconds();
				TimeSpan tsTotal = KairosManager.Instance.CurrentActivity.GetAllTime().StripMilliseconds();

				this._lblCurrentSumForItem.Text = String.Format
																(
																	Resources.ItemWorkoutValues,
																	KairosManager.Instance.CurrentActivity.Name,
																	tsToDay,
																	tsThisWeek,
																	tsTotal
																);
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

		private void OnActivityEdit(object sender, EventArgs e)
		{
			KairosManager.Instance.EditActivity();
		}

		private void OnActivityDelete(object sender, EventArgs e)
		{
			KairosManager.Instance.DeleteActivity();
		}

		private void OnActivityAddWorkInterval(object sender, EventArgs e)
		{
			if (this._tvProjects.SelectedNode != null && this._tvProjects.SelectedNode.Tag is Activity)
			{
				Activity activity = this._tvProjects.SelectedNode.Tag as Activity;

				KairosManager.Instance.CurrentActivity = activity;
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

		private void OnWorkIntervalEdit(object sender, EventArgs e)
		{
			KairosManager.Instance.EditSelectedWorkInterval();
		}

		private void OnWorkIntervalDelete(object sender, EventArgs e)
		{
			KairosManager.Instance.DeleteSelectedWorkInterval();
		}

		#region Private Auviliary
		private void UpdateProjectTreeView()
		{
			this._tvProjects.Nodes.Clear();

			foreach (var project in KairosManager.Instance.ProjectCollection.Projects)
			{
				TreeNode nodeProject = new TreeNode(project.Name);
				nodeProject.Tag = project;
				nodeProject.ImageKey = "rocket";
				nodeProject.SelectedImageKey = "rocket";

				this._tvProjects.Nodes.Add(nodeProject);

				foreach (var activity in project.Activities)
				{
					TreeNode nodeActivity = new TreeNode(activity.Name);
					nodeActivity.Tag = activity;
					nodeActivity.ImageKey = "target";
					nodeActivity.SelectedImageKey = "target";

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


		private void OnWorkIntervalSelected(object sender, EventArgs e)
		{
			if (this._lvActivities.SelectedItems.Count == 1)
			{
				KairosManager.Instance.SelectedWorkInterval = this._lvActivities.SelectedItems[0].Tag as WorkInterval;
			}
		}
	}
}
