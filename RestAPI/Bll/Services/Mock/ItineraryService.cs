﻿using Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Services.Mock
{
	public class ItineraryService : IItineraryService
	{
		public ItineraryDto CreateNewItinerary(ItineraryDto itinerary)
		{
			return new ItineraryDto();
		}

		public IEnumerable<ItineraryDto> GetItinerary(int userId)
		{
			return new List<ItineraryDto>();
		}

		public IEnumerable<ItineraryDto> GetItinerary(string start, string end)
		{
			return new List<ItineraryDto>();
		}

		public ItineraryDto UpdateItinerary(int id, ItineraryDto itinerary)
		{
			return new ItineraryDto();
		}
	}
}
