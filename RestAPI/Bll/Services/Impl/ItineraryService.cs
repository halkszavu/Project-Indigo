using Bll.Dtos;
using Bll.Exceptions;
using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services.Impl
{
	public class ItineraryService : IItineraryService
	{
		private readonly TransportationContext transportationContext;

		public ItineraryService(TransportationContext transportationContext)
		{
			this.transportationContext = transportationContext;
		}

		public ItineraryDto CreateNewItinerary(ItineraryDto itinerary)
		{
			Itinerary entity = new Itinerary()
			{
				Start = itinerary.Start,
				End = itinerary.End,
			};

			transportationContext.Itineraries.Add(entity);
			transportationContext.SaveChanges();
			return new ItineraryDto()
			{
				ID = entity.ID,
				Start = entity.Start,
				End = entity.End,
			};
		}

		public IEnumerable<ItineraryDto> GetItinerary(int userId)
		{
			return new List<ItineraryDto>();
		}

		public IEnumerable<ItineraryDto> GetItinerary(string start, string end)
		{
			if(string.IsNullOrEmpty(end))
			{
				return transportationContext.Itineraries.Where(i => i.Start == start).Select(i => new ItineraryDto()
				{
					ID = i.ID,
					Start = i.Start,
					End = i.End,
				});
			}
			else if(string.IsNullOrEmpty(start))
			{
				return transportationContext.Itineraries.Where(i => i.End == end).Select(i => new ItineraryDto()
				{
					ID = i.ID,
					Start = i.Start,
					End = i.End,
				});
			}
			else
			{
				return transportationContext.Itineraries.Where(i => i.Start == start && i.End == end).Select(i => new ItineraryDto()
				{
					ID = i.ID,
					Start = i.Start,
					End = i.End,
				});
			}
		}

		public void UpdateItinerary(int id, ItineraryDto itinerary)
		{
			var entity = transportationContext.Itineraries.FirstOrDefault(i => i.ID == id);
			if(entity != null)
			{
				entity.Start = itinerary.Start;
				entity.End = itinerary.End;
				transportationContext.SaveChanges();
			}
			else
				throw new EntityNotFoundException("The itinerary with the given id does not exist.");
		}
	}
}
