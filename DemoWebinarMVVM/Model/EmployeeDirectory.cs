using System;
using System.Collections.Generic;

namespace DemoWebinarMVVM
{
	public class EmployeeDirectory
	{
		public EmployeeDirectory()
		{
			generateRandomDirectory();
		}

		void generateRandomDirectory()
		{
			Employees = new List<Employee>();
			Random rdn = new Random();
			string[] names = { "Nombre1", "Nombre2", "Nombre3", "Nombre4" };
			string[] photos =
			{
			"http://www.femside.com/wp-content/uploads/2013/06/suit-woman.jpg",
				"http://previews.123rf.com/images/phakimata/phakimata1103/phakimata110300023/9030612-Experienced-female-business-lawyer-in-suit-Beautiful-Senior-old-woman-with-arms-crossed-isolated--Stock-Photo.jpg",
				"https://angrymiddleagewoman.files.wordpress.com/2011/12/woman-in-suit.jpg",
				"http://steezo.com/wp-content/uploads/2012/12/man-in-suit2.jpg",
				"http://attractmen.org/wp-content/uploads/2015/10/attractmen.org-libra-men.jpg",
			};

			for (int i = 0; i < 3; i++)
			{
				var name = names[rdn.Next(0, 3)];
				Employees.Add(new Employee(
					name,
					photos[rdn.Next(0, 3)],
					(JobPosition)rdn.Next(0, 2),
					name + "@mycompany.com"
				));
			}

		}

		public List<Employee> Employees
		{
			get;
			set;
		}

	}

}

