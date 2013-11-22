namespace Clock {
	partial class Clock {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.time = new System.Windows.Forms.Label();
			this.date = new System.Windows.Forms.Label();
			this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menu_seconds = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// time
			// 
			this.time.AutoSize = true;
			this.time.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.time.Dock = System.Windows.Forms.DockStyle.Fill;
			this.time.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.time.Location = new System.Drawing.Point(0, 0);
			this.time.Name = "time";
			this.time.Size = new System.Drawing.Size(162, 46);
			this.time.TabIndex = 0;
			this.time.Text = "00:00:00";
			this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.time.Click += new System.EventHandler(this.time_Click);
			this.time.MouseDown += new System.Windows.Forms.MouseEventHandler(this.time_MouseDown);
			this.time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.time_MouseMove);
			this.time.MouseUp += new System.Windows.Forms.MouseEventHandler(this.time_MouseUp);
			// 
			// date
			// 
			this.date.AutoSize = true;
			this.date.BackColor = System.Drawing.Color.DodgerBlue;
			this.date.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date.Location = new System.Drawing.Point(5, 46);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(105, 16);
			this.date.TabIndex = 1;
			this.date.Text = "Sat 31 May 2013";
			this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.date.Click += new System.EventHandler(this.date_Click);
			// 
			// menu
			// 
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.menu_seconds,
            this.mi_exit});
			this.menu.Name = "menu";
			this.menu.ShowCheckMargin = true;
			this.menu.Size = new System.Drawing.Size(166, 94);
			this.menu.Opening += new System.ComponentModel.CancelEventHandler(this.menu_Opening);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 28);
			this.toolStripMenuItem1.Text = "Clock";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
			// 
			// menu_seconds
			// 
			this.menu_seconds.Checked = true;
			this.menu_seconds.CheckOnClick = true;
			this.menu_seconds.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menu_seconds.Name = "menu_seconds";
			this.menu_seconds.Size = new System.Drawing.Size(165, 28);
			this.menu_seconds.Text = "Seconds";
			this.menu_seconds.Click += new System.EventHandler(this.menu_seconds_Click);
			// 
			// mi_exit
			// 
			this.mi_exit.Name = "mi_exit";
			this.mi_exit.Size = new System.Drawing.Size(165, 28);
			this.mi_exit.Text = "Exit";
			this.mi_exit.Click += new System.EventHandler(this.mi_exit_Click);
			// 
			// Clock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(160, 65);
			this.ContextMenuStrip = this.menu;
			this.ControlBox = false;
			this.Controls.Add(this.time);
			this.Controls.Add(this.date);
			this.Cursor = System.Windows.Forms.Cursors.Cross;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Clock";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Clock";
			this.Load += new System.EventHandler(this.Clock_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseDown);
			this.menu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label time;
		private System.Windows.Forms.Label date;
		private System.Windows.Forms.ContextMenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem mi_exit;
		private System.Windows.Forms.ToolStripMenuItem menu_seconds;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

	}
}

