﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PDC03_MODULE4
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class activity02 : ContentPage
	{
		ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

		public ObservableCollection<Employee> Employees { get { return employees;} }		
		public activity02 ()
		{
			InitializeComponent ();
			EmployeeView.ItemsSource= employees;

			employees.Add(new Employee { DisplayName = "Scott Galang", Position = "President"});
            employees.Add(new Employee { DisplayName = "Kat Galang", Position = "Vice President" });
            employees.Add(new Employee { DisplayName = "Katzera Galang", Position = "Director" });
            employees.Add(new Employee { DisplayName = "Zera Galang", Position = "Supervisor" });
        }

		private	void Add_item(object sender, EventArgs e)
		{
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
        private void Edit_item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
        private void Delete_item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }


        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}