using Bll.Dtos;
using Bll.Exceptions;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services.Impl
{
	public class RouteService : IRouteService
	{
		private readonly TransportationContext transportationContext;

		public RouteService(TransportationContext transportationContext)
		{
			this.transportationContext = transportationContext;
		}

		public RouteDto CreateNewRoute(RouteDto route)
		{
			if(transportationContext.Routes.Any(r => r.RouteNumber == route.RouteNumber))
			{
				throw new DuplicateEntityException("Route number already exists");
			}
			else
			{
				//save the stops, that are not already in the database
				return null; // fix this!!!
			}
		}

		public RouteDto GetRoute(string routeNumber)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<RouteDto> GetRoutesByRouteNumber(string routeNumber)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<RouteDto> GetRoutesByStop(string stop)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<RouteDto> GetRoutesByStopId(int stopId)
		{
			throw new NotImplementedException();
		}

		public void UpdateRoute(int id, RouteDto route)
		{
			throw new NotImplementedException();
		}
	}
}
