using System.Collections.Generic;

namespace Bll.Dtos
{
	public class StopDto
	{
        public int ID { get; set; }
		public string Name { get; set; }

		public List<RouteDto> Routes { get; set; }
    }
}