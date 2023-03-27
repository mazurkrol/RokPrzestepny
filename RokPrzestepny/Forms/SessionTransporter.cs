namespace RokPrzestepny.Forms
{
	public class SessionTransporter
	{
		public List<SpecialYear> SpecialYears;

		public SessionTransporter() 
		{
		SpecialYears = new List<SpecialYear>();
		}
		public void Adder(SpecialYear specialYear) 
		{
			SpecialYear yearr = new SpecialYear();
			yearr.Year = specialYear.Year;
			yearr.Name = specialYear.Name;
		SpecialYears.Add(yearr);
		}
	}
}
