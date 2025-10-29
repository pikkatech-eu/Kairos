
namespace Kairos.Library
{
	partial class TimeIntervalControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._tlpTimeInterval = new TableLayoutPanel();
			this._nudSecond = new NumericUpDown();
			this.label1 = new Label();
			this.label3 = new Label();
			this._nudMinute = new NumericUpDown();
			this._tlpTimeInterval.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this._nudSecond).BeginInit();
			((System.ComponentModel.ISupportInitialize)this._nudMinute).BeginInit();
			this.SuspendLayout();
			// 
			// _tlpTimeInterval
			// 
			this._tlpTimeInterval.ColumnCount = 4;
			this._tlpTimeInterval.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			this._tlpTimeInterval.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
			this._tlpTimeInterval.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			this._tlpTimeInterval.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
			this._tlpTimeInterval.Controls.Add(this._nudSecond, 2, 0);
			this._tlpTimeInterval.Controls.Add(this.label1, 3, 0);
			this._tlpTimeInterval.Controls.Add(this.label3, 1, 0);
			this._tlpTimeInterval.Controls.Add(this._nudMinute, 0, 0);
			this._tlpTimeInterval.Dock = DockStyle.Fill;
			this._tlpTimeInterval.Location = new Point(0, 0);
			this._tlpTimeInterval.Margin = new Padding(0);
			this._tlpTimeInterval.Name = "_tlpTimeInterval";
			this._tlpTimeInterval.RowCount = 1;
			this._tlpTimeInterval.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpTimeInterval.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
			this._tlpTimeInterval.Size = new Size(309, 28);
			this._tlpTimeInterval.TabIndex = 0;
			// 
			// _nudSecond
			// 
			this._nudSecond.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this._nudSecond.Font = new Font("Consolas", 12F);
			this._nudSecond.Location = new Point(154, 0);
			this._nudSecond.Margin = new Padding(0);
			this._nudSecond.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
			this._nudSecond.Name = "_nudSecond";
			this._nudSecond.Size = new Size(107, 31);
			this._nudSecond.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Location = new Point(261, 0);
			this.label1.Margin = new Padding(0);
			this.label1.Name = "label1";
			this.label1.Padding = new Padding(4, 0, 0, 0);
			this.label1.Size = new Size(48, 28);
			this.label1.TabIndex = 8;
			this.label1.Text = "sec";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = DockStyle.Fill;
			this.label3.Location = new Point(107, 0);
			this.label3.Margin = new Padding(0);
			this.label3.Name = "label3";
			this.label3.Padding = new Padding(4, 0, 0, 0);
			this.label3.Size = new Size(47, 28);
			this.label3.TabIndex = 7;
			this.label3.Text = "min";
			this.label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// _nudMinute
			// 
			this._nudMinute.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this._nudMinute.Font = new Font("Consolas", 12F);
			this._nudMinute.Location = new Point(0, 0);
			this._nudMinute.Margin = new Padding(0);
			this._nudMinute.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
			this._nudMinute.Name = "_nudMinute";
			this._nudMinute.Size = new Size(107, 31);
			this._nudMinute.TabIndex = 9;
			// 
			// TimeIntervalControl
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this._tlpTimeInterval);
			this.Font = new Font("Consolas", 10F);
			this.Name = "TimeIntervalControl";
			this.Size = new Size(309, 28);
			this._tlpTimeInterval.ResumeLayout(false);
			this._tlpTimeInterval.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this._nudSecond).EndInit();
			((System.ComponentModel.ISupportInitialize)this._nudMinute).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _tlpTimeInterval;
		private System.Windows.Forms.NumericUpDown _nudSecond;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown _nudMinute;
	}
}
