using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Bll.Dtos
{
	public class RouteDto
	{
		public long ID { get; set; }
		[Required(ErrorMessage = "Route number is required")]
		public string RouteNumber { get; set; }
		[Required(ErrorMessage = "Provider is required")]
		public string Provider { get; set; }

		public List<StopDto> StopsOutbound { get; set; }
		public List<StopDto> StopsInbound { get; set; }
	}
}
