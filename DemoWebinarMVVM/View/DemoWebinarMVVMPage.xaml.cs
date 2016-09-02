using Xamarin.Forms;

namespace DemoWebinarMVVM
{
	public partial class DemoWebinarMVVMPage : ContentPage
	{
		async void LsEmployees_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var selected = e.SelectedItem as Employee;
			if (selected == null)
				return;
			await Navigation.PushAsync(new EmployeeDetail(selected));
		}

		public DemoWebinarMVVMPage()
		{
			InitializeComponent();
			DemoWebinarMVVMModel vm = new DemoWebinarMVVMModel();
			BindingContext = vm;
			lsEmployees.ItemSelected += LsEmployees_ItemSelected;

		}
	}
}

