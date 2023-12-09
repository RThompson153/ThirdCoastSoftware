namespace ThirdCoastSoftware.Models
{
	public class Tab
	{
		public string Title { get; set; }
		public bool Active { get; set; }
		public IEnumerable<string> Icons { get; set; }
	}
}
