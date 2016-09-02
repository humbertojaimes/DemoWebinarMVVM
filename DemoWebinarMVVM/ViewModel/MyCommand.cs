using System;
using System.Windows.Input;

namespace DemoWebinarMVVM
{
	public class MyCommand:ICommand
	{
		public MyCommand()
		{
		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			throw new NotImplementedException();
		}

		public void Execute(object parameter)
		{
			throw new NotImplementedException();
		}
	}
}

