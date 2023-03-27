using System;

namespace HelloWorldApplication{

	//class HelloWorld{
	
	class Rectangle{
		
		double length;
		double width;
		
		public Rectangle(){
			length = 0.0;
			width = 0.0;			
		}
	
		
		public Rectangle(double l, double w){			
			length = l;
			width = w;
		}
		
		public void AcceptDetails(){			
			length = 4.5;
			width = 3.5;			
		}
		
		public double GetArea(){		
			 return length * width;		
			
		}
		
		public Rectangle CreateObject(){
			
			return new Rectangle(40,50); 
			
		}
		
		
		public void Display(){			
			Console.WriteLine("Length: {0}, Width: {1}", length, width);
			Console.WriteLine("Area: {0}", GetArea());			
		}
						
				
		
	}// Close of Rectangle
	
	
	struct Books
	{
	public string title;
    public string author;
    public string subject;
    public int book_id;
	};

	class MainClass{
		enum Months {JAN, FEB, MAR, APR}; //This enum should be outside the Main fxn
		// but can be inside the class. s
		static void Main(String[] args){
		//This Main method can be within the Rectangle class as well but it has to be within a class. Without
		// class it can not exists. 
	
		Console.WriteLine("Hello World");
		
		Rectangle r = new Rectangle(4,6);
		//r.Display();
	
		Console.WriteLine("After AcceptDetails");
		r.AcceptDetails();
		r.Display();
		
		// object creating and calling within class
		Rectangle obj = r.CreateObject();
		obj.Display();

		Console.WriteLine("size of obj={0}", sizeof(int));
		



	/*
	C# nullable types to which we can assign normal range calues as well as null 
	values. 
    For example, you can store any value from -2,147,483,648 to 2,147,483,647 or null in a Nullable<Int32> variable. 
	Similarly, you can assign true, false, or null in a Nullable<bool>
	syntax:
	<datatype> ? <variablename>= null	
	*/

	int? num1 = null;

	int? num2 = 45;
	double? num3 = new double?();

	double? num4 = 3.14;

	bool? boolVal = new bool?();

	Console.WriteLine(@"nullable values num1 = {0}, num2 = {1} 
	num3 = {2}, num4 = {3}, boolVal = {4}",num1, num2, num3, num4, boolVal);


	// arrays 
	double[] balance = { 2340.0, 4523.69, 3421.0};
	// structs can be declared like function calls
	// structs hold the similar record together
	Books book1 = new Books();
	Books book2;

	book1.title = "Learning C#";
	book1.book_id = 12;
	book1.author = "BHOJ";
	book1.subject = "programming with c#";


	book2.title = "Data Structure and Algorithms";
	book2.book_id = 2;
	book2.author = "BHOJ";
	book2.subject = "programming with python";

	Console.WriteLine("book 1 title ={0}, book2 auth={1} ", book1.title, book2.author);

	

	/*
	Enums => named integer constants.

	An enumeration is a set of named integer constants. An enumerated type is declared using the enum keyword.

	C# enumerations are value data type. In other words, enumeration contains its own values and cannot inherit or cannot pass inheritance.
	
	enum <enumname> {enumeration_values};
	*/

	

	int monthStart = (int)Months.JAN;
	int monthEnd = (int)Months.APR; //in enum only upto apirl

	Console.WriteLine("Start {0} End  {1}", monthStart, monthEnd);




	Console.ReadKey();
		
		
	
	}	// main done
	} // MainClass close
	
	
	//}
}