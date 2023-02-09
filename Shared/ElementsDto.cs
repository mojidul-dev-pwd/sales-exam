using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSalesApp.Shared
{
	public class ElementsDto
	{
		public int? Id { get; set; }
		public string Type { get; set; }
		public decimal? Width { get; set; }
		public decimal? Height { get; set; }
		public int? WindowId { get; set; }
	}
}
