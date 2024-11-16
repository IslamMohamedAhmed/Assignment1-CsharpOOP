using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_OOP_Demo_C_
{
    internal class Car
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private double speed;

		public double Speed
		{
			get { return speed; }
			set { speed = value; }
		}

		public Car() { }

		public Car(int id,string model,double speed)
		{
			this.id = id;
			this.model = model;
			this.speed = speed;
		}




	}
}
