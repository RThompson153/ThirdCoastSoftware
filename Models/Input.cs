using ThirdCoastSoftware.Constants;

namespace ThirdCoastSoftware.Models
{
	public class Input
	{
		public string Name { get; set; }
		public bool Required { get; set; }
		public bool InlineLabel { get; set; }
		public InputType InputType { get; set; }
		public int? MinLength { get; set; }
		public int? MaxLength { get; set; }
		public string Value { get; set; }
	}
}
