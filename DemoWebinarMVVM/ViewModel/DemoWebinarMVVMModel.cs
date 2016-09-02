using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace DemoWebinarMVVM
{
	public class DemoWebinarMVVMModel:INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged = delegate
		{

		};

		void RaiseProperty([CallerMemberName]string propertyName = "")
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		bool isBusy =false;
		public bool IsBusy
		{
			get { return isBusy; }
			set { isBusy = value; 
				RaiseProperty();}
		}

		ObservableCollection<Employee> employees;
		public ObservableCollection<Employee> Employees
		{
			get { return employees; }
			set { employees = value; RaiseProperty(); }
		}

		Employee selectedEmployee;
		public Employee SelectedEmployee
		{
			get { return selectedEmployee; }
			set { selectedEmployee = value; RaiseProperty(); }
		}



		public Command CreateDirectoryCommand
		{
			get;
			set;
		}

		void createDirectory() 
		{ 
			if (!IsBusy)
			{
				IsBusy = true;
				EmployeeDirectory directory = new EmployeeDirectory();
				Employees = directory.Employees;
				SelectedEmployee = Employees[0];
				IsBusy = false;
			}
		}


		public DemoWebinarMVVMModel()
		{
			CreateDirectoryCommand = new Command(()=> createDirectory(),
			                                     ()=> !IsBusy);
		}

	}
}

