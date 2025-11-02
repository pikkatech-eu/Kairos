/***********************************************************************************
* File:         Settings.cs                                                        *
* Contents:     Class Settings                                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-31 20:10                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using System.Text.Json;

namespace Kairos.Library
{
	public class Settings
	{
		#region Constants
		internal static readonly string DEFAULT_SETTINGS_FILE_NAME = "settings.json";
		#endregion

		#region Properties
		[Category("General")]
		[Description("Is set to true, will try to open the last project.")]
		public bool AutoLoadLastProject	{get;set;}	= false;

		[Category("General")]
		[Description("The last opened project file")]
		[ReadOnly(true)]
		public string	LastOpenedProjectCollectionFile	{get;set;}	= "";

		/// <summary>
		/// If set to true, CurrentActivity will be set into 'Paused' state on getting idle.
		/// Running WorkInterval will be completed, closed, and added to the current activity.
		/// </summary>
		public bool AutoPause	{get;set;} = true;

		/// <summary>
		/// If set to true, and CurrentActivity is in the 'Paused' state, the GUI is set into the 'Running' state,
		/// and a new WorkInterval will be started.
		/// </summary>
		public bool AutoResume	{get;set;} = true;
		#endregion

		#region Serialization
		public string ToJson()
		{
			var options = new JsonSerializerOptions {WriteIndented = true};
			return JsonSerializer.Serialize<Settings>(this, options);
		}

		public static Settings FromJson(string json)
		{
			return JsonSerializer.Deserialize<Settings>(json);
		}

		/// <summary>
		/// Saves the settings to a file.
		/// </summary>
		/// <param name="fileName">The name of the file to save under.</param>
		public void Save(string fileName)
		{
			using (StreamWriter writer = new StreamWriter(fileName))
			{
				string json	= this.ToJson();
				writer.Write(json);
			}
		}

		/// <summary>
		/// Loads settings feom a JSON file.
		/// </summary>
		/// <param name="fileName">The name of the file to create from.</param>
		/// <returns>An instance of Settings, if succesful.s</returns>
		public static Settings Load(string fileName)
		{
			using (StreamReader reader= new StreamReader(fileName))
			{
				string json	= reader.ReadToEnd();

				return FromJson(json);
			}
		}

		public void Save()
		{
			string exeFolder = Application.StartupPath;
			string settingsPath	= Path.Combine(exeFolder, DEFAULT_SETTINGS_FILE_NAME);
			this.Save(settingsPath);
		}

		public static Settings Load()
		{
			string exeFolder	= Application.StartupPath;
			string settingsPath	= Path.Combine(exeFolder, DEFAULT_SETTINGS_FILE_NAME);

			if (File.Exists(settingsPath))
			{
				return Load(settingsPath);
			}
			else
			{
				Settings settings = new Settings();
				settings.Save();

				return settings;
			}
		}
		#endregion
	}
}
