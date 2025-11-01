namespace Kairos.Library.Gui
{
	partial class WorkIntervalDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkIntervalDialog));
			this._btOK = new Button();
			this._btCancel = new Button();
			this._tlpWorkInterval = new TableLayoutPanel();
			this._dtpTo = new DateTimePicker();
			this.label1 = new Label();
			this.label2 = new Label();
			this._dtpFrom = new DateTimePicker();
			this.label3 = new Label();
			this._txDescription = new TextBox();
			this._tlpWorkInterval.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btOK
			// 
			this._btOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btOK.BackColor = SystemColors.Control;
			this._btOK.DialogResult = DialogResult.OK;
			this._btOK.Location = new Point(9, 169);
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
			this._btCancel.BackColor = SystemColors.Control;
			this._btCancel.DialogResult = DialogResult.Cancel;
			this._btCancel.Location = new Point(114, 169);
			this._btCancel.Margin = new Padding(0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new Size(80, 32);
			this._btCancel.TabIndex = 0;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = false;
			// 
			// _tlpWorkInterval
			// 
			this._tlpWorkInterval.ColumnCount = 2;
			this._tlpWorkInterval.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
			this._tlpWorkInterval.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpWorkInterval.Controls.Add(this._dtpTo, 1, 1);
			this._tlpWorkInterval.Controls.Add(this.label1, 0, 0);
			this._tlpWorkInterval.Controls.Add(this.label2, 0, 1);
			this._tlpWorkInterval.Controls.Add(this._dtpFrom, 1, 0);
			this._tlpWorkInterval.Controls.Add(this.label3, 0, 2);
			this._tlpWorkInterval.Controls.Add(this._txDescription, 1, 2);
			this._tlpWorkInterval.Dock = DockStyle.Top;
			this._tlpWorkInterval.Location = new Point(0, 0);
			this._tlpWorkInterval.Name = "_tlpWorkInterval";
			this._tlpWorkInterval.RowCount = 3;
			this._tlpWorkInterval.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpWorkInterval.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpWorkInterval.RowStyles.Add(new RowStyle());
			this._tlpWorkInterval.Size = new Size(523, 156);
			this._tlpWorkInterval.TabIndex = 1;
			// 
			// _dtpTo
			// 
			this._dtpTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this._dtpTo.Dock = DockStyle.Fill;
			this._dtpTo.Format = DateTimePickerFormat.Custom;
			this._dtpTo.Location = new Point(115, 28);
			this._dtpTo.Margin = new Padding(0);
			this._dtpTo.Name = "_dtpTo";
			this._dtpTo.Size = new Size(408, 27);
			this._dtpTo.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Location = new Point(0, 0);
			this.label1.Margin = new Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(115, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Start";
			this.label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = DockStyle.Fill;
			this.label2.Location = new Point(0, 28);
			this.label2.Margin = new Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new Size(115, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "End";
			this.label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _dtpFrom
			// 
			this._dtpFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this._dtpFrom.Dock = DockStyle.Fill;
			this._dtpFrom.Format = DateTimePickerFormat.Custom;
			this._dtpFrom.Location = new Point(115, 0);
			this._dtpFrom.Margin = new Padding(0);
			this._dtpFrom.Name = "_dtpFrom";
			this._dtpFrom.Size = new Size(408, 27);
			this._dtpFrom.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = DockStyle.Fill;
			this.label3.Location = new Point(3, 56);
			this.label3.Name = "label3";
			this.label3.Size = new Size(109, 100);
			this.label3.TabIndex = 4;
			this.label3.Text = "Description";
			this.label3.TextAlign = ContentAlignment.TopRight;
			// 
			// _txDescription
			// 
			this._txDescription.Dock = DockStyle.Fill;
			this._txDescription.Location = new Point(118, 59);
			this._txDescription.Multiline = true;
			this._txDescription.Name = "_txDescription";
			this._txDescription.Size = new Size(402, 94);
			this._txDescription.TabIndex = 5;
			// 
			// WorkIntervalDialog
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			this.ClientSize = new Size(523, 210);
			this.Controls.Add(this._tlpWorkInterval);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOK);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = SystemColors.WindowText;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "WorkIntervalDialog";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Work Interval Data";
			this._tlpWorkInterval.ResumeLayout(false);
			this._tlpWorkInterval.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private Button _btOK;
		private Button _btCancel;
		private TableLayoutPanel _tlpWorkInterval;
		private Label label1;
		private Label label2;
		private DateTimePicker _dtpFrom;
		private DateTimePicker _dtpTo;
		private Label label3;
		private TextBox _txDescription;
	}
}