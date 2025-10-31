
namespace Kairos.Library.Gui
{
	partial class TimeIntervalDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeIntervalDialog));
			this._btOk = new Button();
			this._btCancel = new Button();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.label1 = new Label();
			this._dtpFinish = new DateTimePicker();
			this._lblDescription = new Label();
			this._lblName = new Label();
			this._dtpStart = new DateTimePicker();
			this._txComment = new TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btOk
			// 
			this._btOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btOk.DialogResult = DialogResult.OK;
			this._btOk.Location = new Point(12, 180);
			this._btOk.Margin = new Padding(0);
			this._btOk.Name = "_btOk";
			this._btOk.Size = new Size(80, 25);
			this._btOk.TabIndex = 0;
			this._btOk.Text = "OK";
			this._btOk.UseVisualStyleBackColor = true;
			this._btOk.Click += this.OnOk;
			// 
			// _btCancel
			// 
			this._btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btCancel.DialogResult = DialogResult.Cancel;
			this._btCancel.Location = new Point(108, 180);
			this._btCancel.Margin = new Padding(0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new Size(80, 25);
			this._btCancel.TabIndex = 1;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = true;
			this._btCancel.Click += this.OnCancel;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this._dtpFinish, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this._lblDescription, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._lblName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this._dtpStart, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this._txComment, 1, 2);
			this.tableLayoutPanel1.Dock = DockStyle.Top;
			this.tableLayoutPanel1.Location = new Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new Size(472, 163);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Location = new Point(3, 61);
			this.label1.Margin = new Padding(3, 5, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(122, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Comment";
			this.label1.TextAlign = ContentAlignment.TopRight;
			// 
			// _dtpFinish
			// 
			this._dtpFinish.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this._dtpFinish.Dock = DockStyle.Fill;
			this._dtpFinish.Format = DateTimePickerFormat.Custom;
			this._dtpFinish.Location = new Point(131, 31);
			this._dtpFinish.Name = "_dtpFinish";
			this._dtpFinish.Size = new Size(338, 27);
			this._dtpFinish.TabIndex = 1;
			// 
			// _lblDescription
			// 
			this._lblDescription.AutoSize = true;
			this._lblDescription.Dock = DockStyle.Fill;
			this._lblDescription.Location = new Point(3, 33);
			this._lblDescription.Margin = new Padding(3, 5, 3, 0);
			this._lblDescription.Name = "_lblDescription";
			this._lblDescription.Size = new Size(122, 23);
			this._lblDescription.TabIndex = 1;
			this._lblDescription.Text = "End";
			this._lblDescription.TextAlign = ContentAlignment.TopRight;
			// 
			// _lblName
			// 
			this._lblName.AutoSize = true;
			this._lblName.Dock = DockStyle.Fill;
			this._lblName.Location = new Point(3, 0);
			this._lblName.Name = "_lblName";
			this._lblName.Size = new Size(122, 28);
			this._lblName.TabIndex = 0;
			this._lblName.Text = "Start";
			this._lblName.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _dtpStart
			// 
			this._dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this._dtpStart.Dock = DockStyle.Fill;
			this._dtpStart.Format = DateTimePickerFormat.Custom;
			this._dtpStart.Location = new Point(131, 3);
			this._dtpStart.Name = "_dtpStart";
			this._dtpStart.Size = new Size(338, 27);
			this._dtpStart.TabIndex = 0;
			// 
			// _txComment
			// 
			this._txComment.Dock = DockStyle.Fill;
			this._txComment.Location = new Point(131, 59);
			this._txComment.Multiline = true;
			this._txComment.Name = "_txComment";
			this.tableLayoutPanel1.SetRowSpan(this._txComment, 2);
			this._txComment.Size = new Size(338, 101);
			this._txComment.TabIndex = 3;
			// 
			// TimeIntervalDialog
			// 
			this.AcceptButton = this._btOk;
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = this._btCancel;
			this.ClientSize = new Size(472, 224);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOk);
			this.Font = new Font("Consolas", 10F);
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "TimeIntervalDialog";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Work Interval Properties";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btOk;
		private System.Windows.Forms.Button _btCancel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label _lblDescription;
		private System.Windows.Forms.Label _lblName;
		private System.Windows.Forms.DateTimePicker _dtpFinish;
		private System.Windows.Forms.DateTimePicker _dtpStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _txComment;
	}
}