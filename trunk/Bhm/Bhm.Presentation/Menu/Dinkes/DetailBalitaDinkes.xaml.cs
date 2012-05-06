﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bhm.Presentation
{
	/// <summary>
	/// Interaction logic for DetailBalitaPosyandu.xaml
	/// </summary>
	public partial class DetailBalitaDinkes : Window
	{
		public DetailBalitaDinkes()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void bPerbarui_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.Close();
		}

		private void bLihatLaporan_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			var next = new LaporanBalitaDinkes();
			next.Show();
		}
	}
}