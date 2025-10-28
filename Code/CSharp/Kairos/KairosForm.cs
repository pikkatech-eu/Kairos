using Kairos.Library;
using Kairos.Library.Gui.Dialogs;

namespace Kairos
{
	public partial class KairosForm : Form
	{
		public KairosForm()
		{
			InitializeComponent();

			KairosManager.Instance.ProjectCollectionChanged += this.OnProjectCollectionChanged;
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
				TreeNode node = new TreeNode(project.Name);
				node.Tag = project;

				this._tvProjects.Nodes.Add(node);
			}
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
				Project project = e.Node.Tag as Project;

				this._lblProject.Text	= project.Name;
			}
		}
	}
}
