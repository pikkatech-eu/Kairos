namespace Kairos.Library.Gui
{
	partial class KairosAboutDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KairosAboutDialog));
			this._btOK = new Button();
			this._btCancel = new Button();
			this._tlpAbout = new TableLayoutPanel();
			this._txFormula = new TextBox();
			this._txVersion = new TextBox();
			this._pbIcon = new PictureBox();
			this._txKairos = new TextBox();
			this._linkPikkatech = new LinkLabel();
			this._tlpAbout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this._pbIcon).BeginInit();
			this.SuspendLayout();
			// 
			// _btOK
			// 
			this._btOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btOK.BackColor = Color.FromArgb(0, 48, 96);
			this._btOK.DialogResult = DialogResult.OK;
			this._btOK.Location = new Point(9, 192);
			this._btOK.Margin = new Padding(0);
			this._btOK.Name = "_btOK";
			this._btOK.Size = new Size(80, 32);
			this._btOK.TabIndex = 0;
			this._btOK.Text = "OK";
			this._btOK.UseVisualStyleBackColor = false;
			// 
			// _btCancel
			// 
			this._btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btCancel.BackColor = Color.FromArgb(0, 48, 96);
			this._btCancel.DialogResult = DialogResult.Cancel;
			this._btCancel.Location = new Point(114, 192);
			this._btCancel.Margin = new Padding(0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new Size(80, 32);
			this._btCancel.TabIndex = 0;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = false;
			// 
			// _tlpAbout
			// 
			this._tlpAbout.ColumnCount = 2;
			this._tlpAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
			this._tlpAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpAbout.Controls.Add(this._txFormula, 1, 2);
			this._tlpAbout.Controls.Add(this._txVersion, 1, 1);
			this._tlpAbout.Controls.Add(this._pbIcon, 0, 0);
			this._tlpAbout.Controls.Add(this._txKairos, 1, 0);
			this._tlpAbout.Controls.Add(this._linkPikkatech, 1, 3);
			this._tlpAbout.Dock = DockStyle.Top;
			this._tlpAbout.Location = new Point(0, 0);
			this._tlpAbout.Name = "_tlpAbout";
			this._tlpAbout.RowCount = 5;
			this._tlpAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
			this._tlpAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpAbout.RowStyles.Add(new RowStyle());
			this._tlpAbout.Size = new Size(800, 182);
			this._tlpAbout.TabIndex = 1;
			// 
			// _txFormula
			// 
			this._txFormula.BackColor = Color.FromArgb(0, 48, 96);
			this._txFormula.BorderStyle = BorderStyle.None;
			this._txFormula.Dock = DockStyle.Fill;
			this._txFormula.Font = new Font("Consolas", 10F);
			this._txFormula.ForeColor = Color.White;
			this._txFormula.Location = new Point(168, 67);
			this._txFormula.Multiline = true;
			this._txFormula.Name = "_txFormula";
			this._txFormula.ReadOnly = true;
			this._txFormula.Size = new Size(629, 58);
			this._txFormula.TabIndex = 3;
			this._txFormula.Text = "A tool to track working intervals and time registration. Kairòs is Greek for \"right\" or \"opportune\" time. It captures your meaningful time as well as your most productive hours.";
			// 
			// _txVersion
			// 
			this._txVersion.BackColor = Color.FromArgb(0, 48, 96);
			this._txVersion.BorderStyle = BorderStyle.None;
			this._txVersion.Dock = DockStyle.Fill;
			this._txVersion.Font = new Font("Consolas", 11F);
			this._txVersion.ForeColor = Color.White;
			this._txVersion.Location = new Point(168, 35);
			this._txVersion.Name = "_txVersion";
			this._txVersion.ReadOnly = true;
			this._txVersion.Size = new Size(629, 22);
			this._txVersion.TabIndex = 2;
			this._txVersion.Text = "Version 1.0 (2025-11-01)";
			this._txVersion.TextAlign = HorizontalAlignment.Center;
			// 
			// _pbIcon
			// 
			this._pbIcon.Dock = DockStyle.Fill;
			this._pbIcon.Image = Properties.Resources.hourglass_5;
			this._pbIcon.Location = new Point(3, 3);
			this._pbIcon.Name = "_pbIcon";
			this._tlpAbout.SetRowSpan(this._pbIcon, 4);
			this._pbIcon.Size = new Size(159, 154);
			this._pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
			this._pbIcon.TabIndex = 0;
			this._pbIcon.TabStop = false;
			// 
			// _txKairos
			// 
			this._txKairos.BackColor = Color.FromArgb(0, 48, 96);
			this._txKairos.BorderStyle = BorderStyle.None;
			this._txKairos.Dock = DockStyle.Fill;
			this._txKairos.Font = new Font("Consolas", 13F, FontStyle.Bold);
			this._txKairos.ForeColor = Color.White;
			this._txKairos.Location = new Point(168, 3);
			this._txKairos.Name = "_txKairos";
			this._txKairos.ReadOnly = true;
			this._txKairos.Size = new Size(629, 26);
			this._txKairos.TabIndex = 1;
			this._txKairos.Text = "Kairos";
			this._txKairos.TextAlign = HorizontalAlignment.Center;
			// 
			// _linkPikkatech
			// 
			this._linkPikkatech.AutoSize = true;
			this._linkPikkatech.Dock = DockStyle.Fill;
			this._linkPikkatech.Font = new Font("Consolas", 13F);
			this._linkPikkatech.LinkColor = Color.White;
			this._linkPikkatech.Location = new Point(168, 128);
			this._linkPikkatech.Name = "_linkPikkatech";
			this._linkPikkatech.Size = new Size(629, 32);
			this._linkPikkatech.TabIndex = 4;
			this._linkPikkatech.TabStop = true;
			this._linkPikkatech.Text = "www.pikkatech.eu";
			this._linkPikkatech.TextAlign = ContentAlignment.MiddleCenter;
			this._linkPikkatech.VisitedLinkColor = Color.FromArgb(255, 128, 0);
			this._linkPikkatech.LinkClicked += this.OnPikkatechLinkClicked;
			// 
			// KairosAboutDialog
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.ClientSize = new Size(800, 233);
			this.Controls.Add(this._tlpAbout);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOK);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "KairosAboutDialog";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "About Kairos";
			this._tlpAbout.ResumeLayout(false);
			this._tlpAbout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this._pbIcon).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Button _btOK;
		private Button _btCancel;
		private TableLayoutPanel _tlpAbout;
		private PictureBox _pbIcon;
		private TextBox _txKairos;
		private TextBox _txVersion;
		private TextBox _txFormula;
		private LinkLabel _linkPikkatech;
	}
}