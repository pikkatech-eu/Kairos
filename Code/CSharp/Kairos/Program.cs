using Kairos.Library;

namespace Kairos
{
	internal static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			ApplicationConfiguration.Initialize();

			ApplicationConfiguration.Initialize();

			KairosForm form = new KairosForm();

			if (args.Length > 0)
			{
				KairosManager.Instance.FilePath = args[0];
				KairosManager.Instance.PerformProjectLoading();
			}

			Application.Run(form);
		}
	}
}