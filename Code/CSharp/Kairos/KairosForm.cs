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
using Kairos.Library.Gui;
using Kairos.Properties;
using KM = Kairos.Library.KairosManager;
using FV = Factotum.Versioning;
using System.Text.Json;

namespace Kairos
{
	public partial class KairosForm : Form
	{
		#region Construction
		public KairosForm()
		{
			InitializeComponent();
			FV.Version version = new FV.Version();
			version.FromToml();

			this.Text = $"Kairos {version}";

			KairosManager.Instance.ProjectChanged += this.OnProjectCollectionChanged;
			KairosManager.Instance.SelectedActivityChanged += this.OnSelectedActivityChanged;
			KairosManager.Instance.CurrentWorkIntervalChanged += this.OnCurrentlyRunningWorkIntervalChanged;

			this._timerSecond.Tick += this.OnTimerSecondTick;

			if (KairosManager.Instance.Settings.AutoLoadLastProject && !String.IsNullOrEmpty(KM.Instance.Settings.LastOpenedProjectCollectionFile))
			{
				KM.Instance.FilePath = KM.Instance.Settings.LastOpenedProjectCollectionFile;
				KM.Instance.PerformProjectLoading();
			}

			this._timerSecond.Start();

			KairosManager.Instance.Settings.RecentlyOpenedProjectsChanged += this.OnRecentlyOpenedProjectsChanged;

			this.OnRecentlyOpenedProjectsChanged(KairosManager.Instance.Settings.RecentlyOpenedProjects);

			if (KairosManager.Instance.Settings.AutoLoadLastProject && KairosManager.Instance.Settings.RecentlyOpenedProjects.Count > 0)
			{
				KairosManager.Instance.FilePath = KairosManager.Instance.Settings.RecentlyOpenedProjects[0];
				KairosManager.Instance.PerformProjectLoading();
			}

			this.SetTitle();
		}

		private void OnRecentlyOpenedProjectsChanged(List<string> paths)
		{
			List<ToolStripItem> items = new List<ToolStripItem>();

			this._menuItemRecentProjects.DropDownItems.Clear();

			foreach (string path in paths)
			{
				ToolStripItem item = this._menuItemRecentProjects.DropDownItems.Add(path);

				item.Click += this.RecentlyOpenedItemClicked;

				items.Add(item);
			}
		}

		private void RecentlyOpenedItemClicked(object? sender, EventArgs e)
		{
			string filePath = ((ToolStripItem)sender).Text;

			if (File.Exists(filePath))
			{
				KairosManager.Instance.FilePath = filePath;
				KairosManager.Instance.PerformProjectLoading();
			}
			else
			{
				KairosManager.Instance.Settings.RemoveRecentlyOpenedProject(filePath);
			}
		}

		private void SetTitle()
		{
			// TODO: implement this!
		}

		private void OnCurrentlyRunningWorkIntervalChanged(WorkInterval workInterval)
		{
			ListViewItem lviCurrent = this._lvActivities.Items.OfType<ListViewItem>().FirstOrDefault(lvi => (lvi.Tag as WorkInterval).Id == KM.Instance.CurrentWorkInterval.Id);

			if (lviCurrent != null)
			{
				lviCurrent.SubItems[0].Text = KM.Instance.CurrentWorkInterval.Start.ToString("yyyy-MM-dd HH:mm:ss");
				lviCurrent.SubItems[1].Text = ((DateTime)KM.Instance.CurrentWorkInterval.End).ToString("yyyy-MM-dd HH:mm:ss");
				lviCurrent.SubItems[2].Text = $"{KM.Instance.CurrentWorkInterval.Duration.StripMilliseconds()}";

				lviCurrent.SubItems[1].ForeColor = Color.White;
				lviCurrent.SubItems[1].BackColor = Color.DarkGreen;

				lviCurrent.SubItems[2].ForeColor = Color.White;
				lviCurrent.SubItems[2].BackColor = Color.DarkGreen;
			}
		}
		#endregion

		#region Timer event handlers
		private void OnTimerSecondTick(object? sender, EventArgs e)
		{
			TimeSpan ts = KairosManager.Instance.GetTodaysTime().StripMilliseconds();

			this._lblCurrentSumForTime.Text = String.Format("Today's total: {0}", ts);
		}
		#endregion

		#region GUI controls' event handler
		private void OnSelectedActivityChanged(Activity activity)
		{
			this.UpdateActivityListView(activity);
		}

		private void OnNodeSelected(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Tag is Component)
			{
				this._tvComponents.ContextMenuStrip = this._cmsComponent;

				KairosManager.Instance.CurrentComponent = e.Node.Tag as Component;
				this._lblComponent.Text = KairosManager.Instance.CurrentComponent.Name;

				TimeSpan tsToDay = KairosManager.Instance.CurrentComponent.GetTodaysTime().StripMilliseconds();
				TimeSpan tsThisWeek = KairosManager.Instance.CurrentComponent.GetThisWeeksTime().StripMilliseconds();
				TimeSpan tsTotal = KairosManager.Instance.CurrentComponent.GetAllTime().StripMilliseconds();

				this._lblCurrentSumForItem.Text = String.Format
																(
																	Resources.ItemWorkoutValues,
																	KairosManager.Instance.CurrentComponent.Name,
																	tsToDay,
																	tsThisWeek,
																	tsTotal
																);
			}

			else if (e.Node.Tag is Activity)
			{
				this._tvComponents.ContextMenuStrip = this._cmsActivity;
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
		#endregion

		#region KairosManager event handler
		private void OnProjectCollectionChanged(Project pc)
		{
			this._lblCollection.Text = pc.Name;

			this.UpdateProjectTreeView();

			this.UpdateActivityListView(null);

			if (KairosManager.Instance.CurrentComponent != null)
			{
				this._lblComponent.Text = KairosManager.Instance.CurrentComponent.Name;
			}
			else
			{
				this._lblComponent.Text = "***";
			}
		}

		private void OnWorkIntervalSelected(object sender, EventArgs e)
		{
			if (this._lvActivities.SelectedItems.Count == 1)
			{
				KairosManager.Instance.SelectedWorkInterval = this._lvActivities.SelectedItems[0].Tag as WorkInterval;
			}
		}
		#endregion

		#region Menu even handler
		private void OnProjectNew(object sender, EventArgs e)
		{
			KairosManager.Instance.CreateProject();
		}

		private void OnProjectEdit(object sender, EventArgs e)
		{
			KairosManager.Instance.EditProject();
		}

		private void OnComponentNew(object sender, EventArgs e)
		{
			KairosManager.Instance.AddComponent();
		}

		private void OnComponentEdit(object sender, EventArgs e)
		{
			KairosManager.Instance.EditComponent();
		}

		private void OnComponentDelete(object sender, EventArgs e)
		{
			KairosManager.Instance.DeleteComponent();
		}

		private void OnActivityNew(object sender, EventArgs e)
		{
			if (this._tvComponents.SelectedNode != null && this._tvComponents.SelectedNode.Tag is Component)
			{
				KairosManager.Instance.CurrentComponent = this._tvComponents.SelectedNode.Tag as Component;
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
			if (this._tvComponents.SelectedNode != null && this._tvComponents.SelectedNode.Tag is Activity)
			{
				Activity activity = this._tvComponents.SelectedNode.Tag as Activity;

				KairosManager.Instance.CurrentActivity = activity;
				KairosManager.Instance.AddWorkInterval();
			}
		}

		private void OnActivityStartWorkInterval(object sender, EventArgs e)
		{
			if (this._tvComponents.SelectedNode != null && this._tvComponents.SelectedNode.Tag is Activity)
			{
				Activity activity = this._tvComponents.SelectedNode.Tag as Activity;

				KairosManager.Instance.StartCurrentWorkInterval(activity);
			}
		}

		private void OnActivityStopWorkInterval(object sender, EventArgs e)
		{
			KairosManager.Instance.StopCurrentWorkInterval();
		}

		private void OnProjectSaveAs(object sender, EventArgs e)
		{
			KairosManager.Instance.SaveProjectAs();
		}

		private void OnProjectLoad(object sender, EventArgs e)
		{
			KairosManager.Instance.LoadProject();
		}

		private void OnWorkIntervalEdit(object sender, EventArgs e)
		{
			KairosManager.Instance.EditSelectedWorkInterval();
		}

		private void OnWorkIntervalDelete(object sender, EventArgs e)
		{
			KairosManager.Instance.DeleteSelectedWorkInterval();
		}

		private void OnToolsSettings(object sender, EventArgs e)
		{
			KairosManager.Instance.EditSettings();
		}

		private void OnProjectQuit(object sender, EventArgs e)
		{
			if (KM.Instance.CurrentActivity != null && KM.Instance.IsIntervalRunning)
			{
				KM.Instance.StartCurrentWorkInterval(KM.Instance.CurrentActivity);
			}

			KM.Instance.PerformProjectSaving();

			this.Close();
		}

		private void OnHelpAbout(object sender, EventArgs e)
		{
			KairosAboutDialog dialog = new KairosAboutDialog();
			dialog.ShowDialog();
		}
		#endregion

		#region Private Auviliary
		private void UpdateProjectTreeView()
		{
			this._tvComponents.Nodes.Clear();

			foreach (var project in KairosManager.Instance.Project.Components)
			{
				TreeNode nodeProject = new TreeNode(project.Name);
				nodeProject.Tag = project;
				nodeProject.ImageKey = "rocket";
				nodeProject.SelectedImageKey = "rocket";

				this._tvComponents.Nodes.Add(nodeProject);

				foreach (var activity in project.Activities)
				{
					TreeNode nodeActivity = new TreeNode(activity.Name);
					nodeActivity.Tag = activity;
					nodeActivity.ImageKey = "target";
					nodeActivity.SelectedImageKey = "target";

					nodeProject.Nodes.Add(nodeActivity);
				}
			}

			this._tvComponents.ExpandAll();
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

				this._lvActivities.Items.Add(lvi);
			}

			if (this._lvActivities.Items.Count > 0)
			{
				this._lvActivities.EnsureVisible(this._lvActivities.Items.Count - 1);
			}

			this._lvActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this._lvActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		#endregion

		private void OnCopyWorkIntervals(object sender, EventArgs e)
		{
			List<WorkInterval> intervals = this._lvActivities.SelectedItems.OfType<ListViewItem>().Select(lvi => lvi.Tag as WorkInterval).ToList();

			string json = JsonSerializer.Serialize(intervals);

			Clipboard.SetText(json);
		}

		private void OnCutWorkIntervals(object sender, EventArgs e)
		{

		}

		private void OnPasteWorkIntervals(object sender, EventArgs e)
		{
			TreeNode selectedNode = this._tvComponents.SelectedNode;

			if (selectedNode != null && selectedNode.Tag is Activity)
			{
				string json = Clipboard.GetText();

				List<WorkInterval> intervals = JsonSerializer.Deserialize<List<WorkInterval>>(json);

				Activity activity = selectedNode.Tag as Activity;

				activity.WorkIntervals.AddRange(intervals);

				this.UpdateActivityListView(activity);
			}
		}
	}
}
