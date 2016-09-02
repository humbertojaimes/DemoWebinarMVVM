using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoWebinarMVVM
{
	public partial class EmployeeDetail : ContentPage
	{
		public EmployeeDetail()
		{
			InitializeComponent();
		}


		public EmployeeDetail(Employee employee)
		{
			InitializeComponent();
			BindingContext = employee;
		}

	}
}

