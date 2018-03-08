using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace autoTrader.Models
{
	public class Vehicle
	{
		public int ID { get; set; }
		public string type { get; set; }
		public string make { get; set; }
		public string model { get; set; }

		[Range(1900, 2019)]
		public int year { get; set; }

		[Range(0, 10000000)]
		public int price { get; set; }
	}
}
