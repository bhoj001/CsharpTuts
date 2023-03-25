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
	
	
	class MainClass{
		
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
		Console.WriteLine("size of obj={0}", sizeof(r));
		Console.ReadKey();
		
		
	
		}	
	} // main done
	
	
	//}
}