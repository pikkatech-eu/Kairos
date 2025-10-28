
namespace Kairos.Library.Gui.Dialogs
{
	partial class ItemPropertiesDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemPropertiesDialog));
			this._btOk = new Button();
			this._btCancel = new Button();
			this._tlpItemProperties = new TableLayoutPanel();
			this._lblDescription = new Label();
			this._lblName = new Label();
			this._txName = new TextBox();
			this._txDescription = new TextBox();
			this._tlpItemProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btOk
			// 
			this._btOk.DialogResult = DialogResult.OK;
			resources.ApplyResources(this._btOk, "_btOk");
			this._btOk.Name = "_btOk";
			this._btOk.UseVisualStyleBackColor = true;
			this._btOk.Click += this.OnOk;
			// 
			// _btCancel
			// 
			this._btCancel.DialogResult = DialogResult.Cancel;
			resources.ApplyResources(this._btCancel, "_btCancel");
			this._btCancel.Name = "_btCancel";
			this._btCancel.UseVisualStyleBackColor = true;
			this._btCancel.Click += this.OnCancel;
			// 
			// _tlpItemProperties
			// 
			resources.ApplyResources(this._tlpItemProperties, "_tlpItemProperties");
			this._tlpItemProperties.Controls.Add(this._lblDescription, 0, 1);
			this._tlpItemProperties.Controls.Add(this._btCancel, 1, 3);
			this._tlpItemProperties.Controls.Add(this._lblName, 0, 0);
			this._tlpItemProperties.Controls.Add(this._btOk, 0, 3);
			this._tlpItemProperties.Controls.Add(this._txName, 1, 0);
			this._tlpItemProperties.Controls.Add(this._txDescription, 1, 1);
			this._tlpItemProperties.Name = "_tlpItemProperties";
			// 
			// _lblDescription
			// 
			resources.ApplyResources(this._lblDescription, "_lblDescription");
			this._lblDescription.Name = "_lblDescription";
			// 
			// _lblName
			// 
			resources.ApplyResources(this._lblName, "_lblName");
			this._lblName.Name = "_lblName";
			// 
			// _txName
			// 
			resources.ApplyResources(this._txName, "_txName");
			this._txName.Name = "_txName";
			// 
			// _txDescription
			// 
			resources.ApplyResources(this._txDescription, "_txDescription");
			this._txDescription.Name = "_txDescription";
			// 
			// ItemPropertiesDialog
			// 
			this.AcceptButton = this._btOk;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = this._btCancel;
			this.Controls.Add(this._tlpItemProperties);
			this.Name = "ItemPropertiesDialog";
			this._tlpItemProperties.ResumeLayout(false);
			this._tlpItemProperties.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btOk;
		private System.Windows.Forms.Button _btCancel;
		private System.Windows.Forms.TableLayoutPanel _tlpItemProperties;
		private System.Windows.Forms.Label _lblDescription;
		private System.Windows.Forms.Label _lblName;
		private System.Windows.Forms.TextBox _txName;
		private System.Windows.Forms.TextBox _txDescription;
	}
}