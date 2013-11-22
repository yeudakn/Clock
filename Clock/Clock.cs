using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clock {
	public partial class Clock: Form {
		Timer t;
		String time_format = "HH:mm:ss";
		String date_format = "ddd dd MMM yyyy";

		public Clock() {
			InitializeComponent();
		}

		private void update() {
			var now = System.DateTime.Now;
			date.Text = now.ToString(date_format);
			time.Text = now.ToString(time_format);
		}

		private void tick(object sender, EventArgs e) {
			t.Interval = 1000;
			t.Start();
			update();
		}

		private void Clock_Load(object sender, EventArgs e) {
			t = new Timer();
			t.Tick += tick;
			tick(sender, e);
		}

		private void Clock_MouseDown(object sender, MouseEventArgs e) {
			
		}

		Point down;
		Boolean moving = false;
		private void time_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				down = e.Location;
				moving = true;
			}
		}

		private void time_MouseMove(object sender, MouseEventArgs e) {
			if (moving) 
				this.Location = new Point(this.Location.X - (down.X - e.Location.X), this.Location.Y - (down.Y - e.Location.Y));
		}

		private void time_MouseUp(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left)
				moving = false;
		}

		private void mi_exit_Click(object sender, EventArgs e) {
			Application.Exit(); 
		}

		private void menu_Opening(object sender, CancelEventArgs e) {

		}

		private void date_Click(object sender, EventArgs e) {

		}

		private void menu_seconds_Click(object sender, EventArgs e) {
			if (menu_seconds.Checked)
				time_format = "HH:mm:ss";
			else
				time_format = "HH:mm";
			update();
		}

		private void time_Click(object sender, EventArgs e) {
		}
	}
}
