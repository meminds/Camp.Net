using System;


namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			Course course1 = new Course();
			course1.CourseName = "C#";
			course1.Instructor = "Engin Demiroğ";
			course1.ViewsRate = 100;

			Course course2 = new Course();
			course2.CourseName = "Go";
			course2.Instructor = "Derya Coluk";
			course2.ViewsRate = 12;

			Course course3 = new Course();
			course3.CourseName = "Python";
			course3.Instructor = "Mustafa Veryak";
			course3.ViewsRate = 78;

			Course[] courses = new Course[] { course1, course2, course3 };
			foreach (Course course in courses)
			{
				Console.WriteLine(course.CourseName + ": " + course.Instructor);
			}
		}
	}

	class Course
	{
		public string CourseName { get; set; }
		public string Instructor { get; set; }
		public int ViewsRate { get; set; }
	}


}
