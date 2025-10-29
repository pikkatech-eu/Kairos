using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using Kairos.Library.Gui.Dialogs;
using Kairos.Library.Properties;

namespace Kairos.Library
{
	public class KairosManager
	{
		private static readonly Lazy<KairosManager> _instance = new Lazy<KairosManager>(() => new KairosManager());
		public static KairosManager Instance => _instance.Value;
		private KairosManager() 
		{
			// Initialization logic here
		}

		/// <summary>
		/// Path to currect project collection
		/// </summary>
		public string FilePath	{get;set;} = "";

		public ProjectCollection ProjectCollection	{get;internal set;} = new ProjectCollection();

		public event Action<ProjectCollection> ProjectCollectionChanged;

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
	}
}
