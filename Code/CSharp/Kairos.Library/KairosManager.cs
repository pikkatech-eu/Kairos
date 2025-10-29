/***********************************************************************************
* File:         KairosManager.cs                                                   *
* Contents:     Class KairosManager                                                *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-29 22:46                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Kairos.Library.Entities;
using Kairos.Library.Gui;
using Kairos.Library.Gui.Dialogs;
using Kairos.Library.Properties;
using Timer = System.Windows.Forms.Timer;

namespace Kairos.Library
{
	public class KairosManager
	{
		private static readonly Lazy<KairosManager> _instance = new Lazy<KairosManager>(() => new KairosManager());
		public static KairosManager Instance => _instance.Value;
		private KairosManager() 
		{
			this._timerCurrentWorkInterval = new System.Windows.Forms.Timer();

			this._timerCurrentWorkInterval.Interval	= 1000;

			this._timerCurrentWorkInterval.Tick += this.OnCurrentWorkIntervalTick;
		}

		private void OnCurrentWorkIntervalTick(object? sender, EventArgs e)
		{
			if (this.CurrentWorkInterval != null)
			{
				this.CurrentWorkInterval.End	= DateTime.Now;

				this.CurrentWorkIntervalChanged?.Invoke(this.CurrentWorkInterval);
			}
		}

		private Timer	_timerCurrentWorkInterval = null;

		/// <summary>
		/// Path to currect project collection
		/// </summary>
		public string FilePath	{get;set;} = "";

		public ProjectCollection ProjectCollection	{get;internal set;} = new ProjectCollection();

		public WorkInterval	CurrentWorkInterval	{get;internal set;} = null;

		public event Action<ProjectCollection> ProjectCollectionChanged;

		public event Action<Activity> SelectedActivityChanged;
		 
		public event Action<WorkInterval> CurrentWorkIntervalChanged;

		public void CreateProjectCollection()
		{
			ItemPropertiesDialog dialog = new ItemPropertiesDialog();
			dialog.Text = Resources.ProjectCollectionProperties;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.ProjectCollection = new ProjectCollection();
				this.ProjectCollection.Name	= dialog.ItemName;
				this.ProjectCollection.Description	= dialog.ItemDescription;

				this.ProjectCollectionChanged?.Invoke(this.ProjectCollection);
			}
		}

		public void AddProject()
		{
			ItemPropertiesDialog dialog = new ItemPropertiesDialog();
			dialog.Text = Resources.ProjectProperties;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Project project = new Project();
				project.Name	= dialog.ItemName;
				project.Description	= dialog.ItemDescription;

				this.ProjectCollection.Projects.Add(project);

				this.ProjectCollectionChanged?.Invoke(this.ProjectCollection);
			}
		}

		public void AddActivity(Project project)
		{
			ItemPropertiesDialog dialog = new ItemPropertiesDialog();
			dialog.Text = Resources.ActivityProperties;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Activity activity = new Activity();
				activity.Name	= dialog.ItemName;
				activity.Description	= dialog.ItemDescription;

				project.Activities.Add(activity);

				this.ProjectCollectionChanged?.Invoke(this.ProjectCollection);
			}
		}

		public void AddAddWorkInterval(Activity activity)
		{
			WorkIntervalDialog dialog = new WorkIntervalDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				WorkInterval workInterval = dialog.WorkInterval;

				activity.WorkIntervals.Add(workInterval);

				this.SelectedActivityChanged?.Invoke(activity);
			}
		}

		public void StartCurrentWorkInterval(Activity activity)
		{
			this.CurrentWorkInterval = new WorkInterval();
			this.CurrentWorkInterval.Start	= DateTime.Now;
			activity.WorkIntervals.Add(this.CurrentWorkInterval);

			this._timerCurrentWorkInterval.Start();
		}
	}
}
