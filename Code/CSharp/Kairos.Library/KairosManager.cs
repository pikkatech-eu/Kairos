/***********************************************************************************
* File:         KairosManager.cs                                                   *
* Contents:     Class KairosManager                                                *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-29 22:46                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Runtime.CompilerServices;
using Kairos.Library.Entities;
using Kairos.Library.Gui;
using Kairos.Library.Gui.Dialogs;
using Kairos.Library.Properties;
using Timer = System.Windows.Forms.Timer;

[assembly:InternalsVisibleTo("Kairos")]

namespace Kairos.Library
{
	public class KairosManager
	{
		#region Private Members
		private Timer	_timerCurrentWorkInterval = null;
		#endregion

		#region Sigletonium
		private static readonly Lazy<KairosManager> _instance = new Lazy<KairosManager>(() => new KairosManager());
		public static KairosManager Instance => _instance.Value;
		private KairosManager() 
		{
			this._timerCurrentWorkInterval = new System.Windows.Forms.Timer();

			this._timerCurrentWorkInterval.Interval	= 1000;

			this._timerCurrentWorkInterval.Tick += this.OnCurrentWorkIntervalTick;
		}
		#endregion

		private void OnCurrentWorkIntervalTick(object? sender, EventArgs e)
		{
			if (this.CurrentWorkInterval != null)
			{
				this.CurrentWorkInterval.End	= DateTime.Now;

				this.SelectedActivityChanged?.Invoke(this.CurrentActivity);
			}
		}

		#region Properties
		/// <summary>
		/// Path to currect project collection
		/// </summary>
		public string FilePath	{get;set;} = "";

		public ProjectCollection ProjectCollection	{get;internal set;} = new ProjectCollection();

		public Project	CurrentProject	{get;internal set;} = null;

		public Activity	CurrentActivity	{get;internal set;} = null;

		public WorkInterval	CurrentWorkInterval	{get;internal set;} = null;

		public bool	IsIntervalRunning = false;
		#endregion

		#region Events
		public event Action<ProjectCollection> ProjectCollectionChanged;

		public event Action<Activity> SelectedActivityChanged;
		#endregion

		public void CreateProjectCollection()
		{
			ItemPropertiesDialog dialog	= new ItemPropertiesDialog();
			dialog.Text					= Resources.ProjectCollectionProperties;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.ProjectCollection				= new ProjectCollection();
				this.ProjectCollection.Name			= dialog.ItemName;
				this.ProjectCollection.Description	= dialog.ItemDescription;

				this.ProjectCollectionChanged?.Invoke(this.ProjectCollection);
			}
		}

		public void AddProject()
		{
			ItemPropertiesDialog dialog = new ItemPropertiesDialog();
			dialog.Text					= Resources.ProjectProperties;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Project project = new Project();
				project.Name	= dialog.ItemName;
				project.Description	= dialog.ItemDescription;

				this.ProjectCollection.Projects.Add(project);

				this.ProjectCollectionChanged?.Invoke(this.ProjectCollection);
			}
		}

		public void AddActivity()
		{
			if (this.CurrentProject == null)
			{
				return;
			}

			ItemPropertiesDialog dialog = new ItemPropertiesDialog();

			dialog.Text = Resources.ActivityProperties;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Activity activity		= new Activity();
				activity.Name			= dialog.ItemName;
				activity.Description	= dialog.ItemDescription;

				this.CurrentProject.Activities.Add(activity);

				this.ProjectCollectionChanged?.Invoke(this.ProjectCollection);
			}
		}

		public void AddAddWorkInterval()
		{
			if (this.CurrentActivity == null)
			{
				return;
			}

			WorkIntervalDialog dialog = new WorkIntervalDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				WorkInterval workInterval = dialog.WorkInterval;

				this.CurrentActivity.WorkIntervals.Add(workInterval);

				this.SelectedActivityChanged?.Invoke(this.CurrentActivity);
			}
		}

		public void StartCurrentWorkInterval(Activity activity)
		{
			this.CurrentWorkInterval		= new WorkInterval();
			this.CurrentWorkInterval.Start	= DateTime.Now;
			activity.WorkIntervals.Add(this.CurrentWorkInterval);

			this._timerCurrentWorkInterval.Start();
			this.IsIntervalRunning = true;

			this.SelectedActivityChanged?.Invoke(activity);
		}

		/// <summary>
		/// TODO -> work here: add CurrentProject, CurrentActivity.
		/// </summary>
		public void StopCurrentWorkInterval()
		{
			if (this.CurrentWorkInterval == null)
			{
				return;
			}

			if (this.IsIntervalRunning)
			{
				this.CurrentWorkInterval.End = DateTime.Now;
				this._timerCurrentWorkInterval.Stop();
				this.IsIntervalRunning = false;

				this.SelectedActivityChanged?.Invoke(this.CurrentActivity);

				this.SaveProjectCollection();
			}
		}

		public void SaveProjectCollectionAs()
		{
			SaveFileDialog dialog	= new SaveFileDialog();
			dialog.Filter= "Kairos files (*.kai)|*.kai|Json files (*json)|*.json";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.FilePath = dialog.FileName;

				this.SaveProjectCollection();
			}
		}

		private void SaveProjectCollection()
		{
			if (String.IsNullOrEmpty(this.FilePath))
			{
				this.SaveProjectCollectionAs();
			}
			else
			{
				this.ProjectCollection.Save(this.FilePath);
			}
		}

		public void LoadProjectCollection()
		{
			OpenFileDialog dialog	= new OpenFileDialog();
			dialog.Filter			= "Kairos files (*.kai)|*.kai|Json files (*json)|*.json";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.FilePath = dialog.FileName;

				this.ProjectCollection = ProjectCollection.Load(this.FilePath);

				this.ProjectCollectionChanged?.Invoke(this.ProjectCollection);
			}
		}

		public TimeSpan GetTodaysTime()
		{
			double y = this.ProjectCollection.Projects.Sum(p => p.GetTodaysTime().TotalSeconds);

			return TimeSpan.FromSeconds(y);
		}
	}
}
