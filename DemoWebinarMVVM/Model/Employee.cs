using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoWebinarMVVM
{
	public enum JobPosition
	{
		Excecutive,
		Operator,
		Supervisor
	}

	public class Employee :INotifyPropertyChanged
	{
		
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value;
				Email = name + "@mycompany.com";
				RaiseProperty();
			}
		}

		private string photoUrl;
		public string PhotoUrl
		{
			get { return photoUrl; }
			set { photoUrl = value; RaiseProperty(); }
		}

		private JobPosition position;
		public JobPosition Position { 
			get; 
			set; 
		}

		private string email;

		public event PropertyChangedEventHandler PropertyChanged = delegate {
			
		};

		void RaiseProperty([CallerMemberName]string propertyName = "")
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		public string Email
		{
			get { return email; }
			set { 
				email = value;
				RaiseProperty();
			}
		}

		public Employee(string name, string photoUrl, JobPosition position, string email)
		{
			Name = name;
			PhotoUrl = photoUrl;
			Position = position;
			Email = email;
		}
	}
}

