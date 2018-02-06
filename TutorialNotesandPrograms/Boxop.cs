using System;

namespace OperatorOvlApplication {
	class Box {
		private double length;  //Length of a box
		private double breadth; // Breadth of a box
		private double height;

		public double getVolume() {
			return (length * breadth * height);
		}
		public void setLength( double len) {
			length = len;
		}
		public void setBreadth( double bre) {
			breadth = bre;
		}
		public void setHeight(double hei){
			height = hei;
		}
	
		public static Box operator+ (Box b, Box c) {
			Box box = new Box();
			box.length = b.length + c.length;
			box.breadth = b.breadth + c.breadth;
			box.height = b.height + c.height;	
			return box;
		}
	}
	class Tester {
		static void Main(string[] args) {
			Box Box1 = new Box();
			Box Box2 = new Box();
			Box Box3 = new Box();
			Box Box4 = new Box();
			double volume = 0.0;
			
			Box1.setLength(12.0);
			Box1.setBreadth(4.0);
			Box1.setHeight(5.10);


			Box2.setLength(122.0);
			Box2.setBreadth(41.0);
			Box2.setHeight(57.10);

			Console.WriteLine("{0}", Box2.getVolume());
			Box3 = Box1 + Box2;
			volume = Box3.getVolume();
			Console.WriteLine("Volume of Box1 : {0}", Box1.getVolume());
			Console.WriteLine("Volume of Box2 : {0}", Box2.getVolume());
			Console.WriteLine("Volume of Box3 : {0}", volume);
			Console.ReadKey();
			
		}
	}		
}