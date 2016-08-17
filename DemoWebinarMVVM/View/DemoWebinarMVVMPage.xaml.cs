using Xamarin.Forms;

namespace DemoWebinarMVVM
{
	public partial class DemoWebinarMVVMPage : ContentPage
	{
		public DemoWebinarMVVMPage()
		{
			InitializeComponent();
			EmployeeDirectory directory = new EmployeeDirectory();
			BindingContext = directory.Employees[1];
		}
	}
}

