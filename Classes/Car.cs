
namespace Classes
{
	public class Car
	{
		public string Marka { get; set; }
        public string Model { get; set; }
		public int Year { get; set; }
		private decimal Price;
        public decimal Speed { get; set; }
		public decimal GetPrice
		{
			get { return Price; }
			set {  Price = value; }
		}
		public Car(string model,int year,decimal getprice,decimal speed)
		{
			Model = model;
			Year = year;
			GetPrice = getprice;
			Speed = speed;
		}
		public string GetCarInfo()
		{
			return $"\t\tMashina ma'lumotlari \n {Marka} \n {Model} \n {Year} \n {Price}";
		}
		public decimal CalculateDepreciation(int years)
		{
			decimal CalculatePrice = Price;
			
			for (int i = 0; i < years; i++)
			{
				CalculatePrice -= CalculatePrice / 10;
			}
			return CalculatePrice;
		}

    }
}
