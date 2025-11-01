/***********************************************************************************
* File:         KairosManager.cs                                                   *
* Contents:     Class KairosManager                                                *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-29 22:46                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Runtime.CompilerServices;
using BugLite.Library.Gui.Dialogs;
using Kairos.Library.Entities;
using Kairos.Library.Gui;
using Kairos.Library.Gui.Dialogs;
using Kairos.Library.Properties;
using Timer = System.Windows.Forms.Timer;

[assembly: InternalsVisibleTo("Kairos")]

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
			this.Settings = Settings.Load();

			this._timerCurrentWorkInterval = new System.Windows.Forms.Timer();

			this._timerCurrentWorkInterval.Interval	= 1000;

			this._timerCurrentWorkInterval.Tick += this.OnCurrentWorkIntervalTick;
		}
		#endregion

		#region Properties
		/// <summary>
		/// Path to currect component collection
		/// </summary>
		public string FilePath	{get;set;} = "";

		public Project Project	{get;internal set;} = new Project();

		public Component	CurrentComponent	{get;internal set;} = null;

		public Activity	CurrentActivity	{get;internal set;} = null;

		/// <summary>
		/// Running WorkInterval
		/// </summary>
		public WorkInterval	CurrentWorkInterval	{get;internal set;} = null;

		/// <summary>
		/// WorkInterval selected in ListView
		/// </summary>
		public WorkInterval	SelectedWorkInterval	{get;internal set;} = null;

		public bool	IsIntervalRunning = false;

		public Settings Settings	{get;set;}	= new Settings();
		#endregion

		#region Events
		public event Action<Project> ProjectChanged;

		public event Action<Activity> SelectedActivityChanged;

		public event Action<WorkInterval> CurrentWorkIntervalChanged;
		#endregion

		#region Fixture management
		public void CreateProject()
		{
			ItemPropertiesDialog dialog	= new ItemPropertiesDialog();
			dialog.Text					= Resources.ProjectCollectionProperties;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.Project				= new Project();
				this.Project.Name			= dialog.ItemName;
				this.Project.Description	= dialog.ItemDescription;

				this.ProjectChanged?.Invoke(this.Project);
			}
		}

		public void EditProject()
		{
			ItemPropertiesDialog dialog	= new ItemPropertiesDialog();
			dialog.Text					= Resources.ProjectCollectionProperties;
			dialog.ItemName				= this.Project.Name;
			dialog.ItemDescription		= this.Project.Description;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.Project.Name			= dialog.ItemName;
				this.Project.Description	= dialog.ItemDescription;
				this.PerformProjectSaving();

				this.ProjectChanged?.Invoke(this.Project);
			}
		}

		public void SaveProjectAs()
		{
			SaveFileDialog dialog	= new SaveFileDialog();
			dialog.Filter			= Resources.FileDialogFilter;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.FilePath = dialog.FileName;
				this.Settings.LastOpenedProjectCollectionFile	= this.FilePath;

				this.PerformProjectSaving();
			}
		}

		public void LoadProject()
		{
			OpenFileDialog dialog	= new OpenFileDialog();
			dialog.Filter			= Resources.FileDialogFilter;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.FilePath = dialog.FileName;

				this.Settings.LastOpenedProjectCollectionFile = this.FilePath;

				this.PerformProjectLoading();
			}
		}
		#endregion

		#region Component management
		public void AddComponent()
		{
			ItemPropertiesDialog dialog = new ItemPropertiesDialog();
			dialog.Text					= Resources.ProjectProperties;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Component component		= new Component();
				component.Name			= dialog.ItemName;
				component.Description	= dialog.ItemDescription;

				this.Project.Components.Add(component);

				this.ProjectChanged?.Invoke(this.Project);
			}
		}

		internal void EditComponent()
		{
			if (this.CurrentComponent == null)
			{
				return;
			}

			ItemPropertiesDialog dialog = new ItemPropertiesDialog();
			dialog.Text					= Resources.ProjectProperties;

			dialog.ItemName				= this.CurrentComponent.Name;
			dialog.ItemDescription		= this.CurrentComponent.Description;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.CurrentComponent.Name		= dialog.ItemName;
				this.CurrentComponent.Description	= dialog.ItemDescription;

				this.ProjectChanged?.Invoke(this.Project);
				
				this.PerformProjectSaving();
			}
		}

		internal void DeleteComponent()
		{
			if (this.CurrentComponent == null)
			{
				return;
			}

			if 
				(
					MessageBox.Show
									(
										String.Format(Resources.ShallProjectBeDeleted, this.CurrentComponent.Name), 
										Resources.ProjectAboutToBeDeleted, 
										MessageBoxButtons.OKCancel, 
										MessageBoxIcon.Question
									) == DialogResult.OK
				)
			{
				this.Project.Components.Remove(this.CurrentComponent);
				this.CurrentComponent = null;

				this.ProjectChanged?.Invoke(this.Project);
				
				this.PerformProjectSaving();
			}
		}
		#endregion

		#region Activity management
		public void AddActivity()
		{
			if (this.CurrentComponent == null)
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

				this.CurrentComponent.Activities.Add(activity);

				this.ProjectChanged?.Invoke(this.Project);
			}
		}

		internal void EditActivity()
		{
			if (this.CurrentActivity == null)
			{
				return;
			}

			ItemPropertiesDialog dialog = new ItemPropertiesDialog();
			dialog.Text = Resources.ActivityProperties;

			dialog.ItemName			= this.CurrentActivity.Name;
			dialog.ItemDescription	= this.CurrentActivity.Description;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.CurrentActivity.Name			= dialog.ItemName;
				this.CurrentActivity.Description	= dialog.ItemDescription;

				this.ProjectChanged?.Invoke(this.Project);
				
				this.PerformProjectSaving();
			}
		}

		internal void DeleteActivity()
		{
			if (this.CurrentActivity == null)
			{
				return;
			}

			if 
				(
					MessageBox.Show
									(
										String.Format(Resources.ShallActivityBeDeleted, this.CurrentActivity.Name), 
										Resources.ActivityAboutToBeDeleted, 
										MessageBoxButtons.OKCancel, 
										MessageBoxIcon.Question
									) == DialogResult.OK
				)
			{
				this.CurrentComponent.Activities.Remove(this.CurrentActivity);
				this.CurrentActivity = null;

				this.ProjectChanged?.Invoke(this.Project);
				
				this.PerformProjectSaving();
			}
		}
		#endregion

		#region Work interval management
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

				this.PerformProjectSaving();
			}
		}

		public void EditSelectedWorkInterval()
		{
			if (this.SelectedWorkInterval == null)
			{
				return;
			}

			WorkIntervalDialog dialog	= new WorkIntervalDialog();
			dialog.Text					= Resources.WorkIntervalProperties;

			dialog.WorkInterval = this.SelectedWorkInterval;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.SelectedWorkInterval = dialog.WorkInterval;

				int index = this.CurrentActivity.WorkIntervals.FindIndex(wi => wi.Id == this.SelectedWorkInterval.Id);

				if (index >= 0)
				{
					this.CurrentActivity.WorkIntervals[index] = dialog.WorkInterval;

					this.SelectedActivityChanged?.Invoke(this.CurrentActivity);

					this.PerformProjectSaving();
				}
			}
		}

		public void DeleteSelectedWorkInterval()
		{
			if (this.SelectedWorkInterval == null)
			{
				return;
			}

			if 
			(
				MessageBox.Show
								(
									String.Format(Resources.ShallSelectedWorkIntervalBeDeleted), 
									Resources.WorkIntervalAboutToBeDeleted, 
									MessageBoxButtons.OKCancel, 
									MessageBoxIcon.Question
								) == DialogResult.OK
			)
			{
				int index = this.CurrentActivity.WorkIntervals.FindIndex(wi => wi.Id == this.SelectedWorkInterval.Id);

				if (index >= 0)
				{
					this.CurrentActivity.WorkIntervals.RemoveAt(index);

					this.SelectedActivityChanged?.Invoke(this.CurrentActivity);

					this.PerformProjectSaving();
				}
			}
		}
		#endregion

		#region Working time measuring
		/// <summary>
		/// Returns the time spent since the beginning of the day for all projects and activities.
		/// </summary>
		/// <returns></returns>
		public TimeSpan GetTodaysTime()
		{
			double y = this.Project.Components.Sum(p => p.GetTodaysTime().TotalSeconds);

			return TimeSpan.FromSeconds(y);
		}
		#endregion

		#region Settings Management
		internal void EditSettings()
		{
			SettingsDialog dialog = new SettingsDialog();
			dialog.Settings	= this.Settings;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.Settings	= dialog.Settings; 

				this.Settings.Save();
			}
		}
		#endregion

		#region Private event handlers
		private void OnCurrentWorkIntervalTick(object? sender, EventArgs e)
		{
			if (this.CurrentWorkInterval != null)
			{
				this.CurrentWorkInterval.End	= DateTime.Now;

				this.CurrentWorkIntervalChanged?.Invoke(this.CurrentWorkInterval);
			}
		}
		#endregion

		#region Internal & Private Auxiliary
		internal void PerformProjectLoading()
		{
			this.Project = Project.Load(this.FilePath);

			this.ProjectChanged?.Invoke(this.Project);
		}

		private void PerformProjectSaving()
		{
			if (String.IsNullOrEmpty(this.FilePath))
			{
				this.SaveProjectAs();
			}
			else
			{
				this.Project.Save(this.FilePath);
			}
		}
		#endregion
	}
}
