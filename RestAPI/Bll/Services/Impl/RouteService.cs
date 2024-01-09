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
				//save the route
				Route entity = new()
				{
					RouteNumber = route.RouteNumber,
					Provider = route.Provider
				};
				transportationContext.Routes.Add(entity);

				//save the stops, that are not already in the database
				foreach(var stop in route.StopsOutbound.Concat(route.StopsInbound))
				{
					if(!transportationContext.Stops.Any(s => s.Name == stop.Name))
					{
						transportationContext.Stops.Add(new Stop
						{
							Name = stop.Name
						});
					}
				}

				//save the stops in order
				for(int i = 0; i < route.StopsOutbound.Count; i++)
				{
					transportationContext.RouteStops.Add(new RouteStop
					{
						RouteID = entity.ID,
						StopID = transportationContext.Stops.First(s => s.Name == route.StopsOutbound[i].Name).ID,
						Order = i,
						Direction = Direction.Outbound
					});
				}
				for(int i = 0; i < route.StopsInbound.Count; i++)
				{
					transportationContext.RouteStops.Add(new RouteStop
					{
						RouteID = entity.ID,
						StopID = transportationContext.Stops.First(s => s.Name == route.StopsInbound[i].Name).ID,
						Order = i,
						Direction = Direction.Inbound
					});
				}
				
				transportationContext.SaveChanges();
				route.ID = entity.ID;
				return route;
			}
		}

		public RouteDto GetRoute(string routeNumber)
		{
			Route result = transportationContext.Routes.FirstOrDefault(r => r.RouteNumber == routeNumber);
			if(result == null)
				throw new EntityNotFoundException("Route not found with the specified route number");
			else
			{
				RouteDto route = new()
				{
					ID = result.ID,
					RouteNumber = result.RouteNumber,
					Provider = result.Provider
				};

				//get the stops in both directions
				route.StopsOutbound = transportationContext.RouteStops.Where(rs => rs.RouteID == result.ID && rs.Direction == Direction.Outbound).OrderBy(rs => rs.Order).Select(rs => rs.Stop).Select(s => new StopDto() { ID = s.ID, Name = s.Name}).ToList();
				route.StopsInbound = transportationContext.RouteStops.Where(rs => rs.RouteID == result.ID && rs.Direction == Direction.Inbound).OrderBy(rs => rs.Order).Select(rs => rs.Stop).Select(s => new StopDto() { ID = s.ID, Name = s.Name}).ToList();

				return route;
			}
		}

		public IEnumerable<RouteDto> GetRoutesByRouteNumber(string routeNumber)
		{
			var p = transportationContext.Routes.Where(r => r.RouteNumber.Contains(routeNumber));
			if(p.Any())
			{
				return p.Select(r => new RouteDto()
				{
					ID = r.ID,
					RouteNumber = r.RouteNumber,
					Provider = r.Provider,
					StopsOutbound = transportationContext.RouteStops.Where(rs => rs.RouteID == r.ID && rs.Direction == Direction.Outbound).OrderBy(rs => rs.Order).Select(rs => rs.Stop).Select(s => new StopDto() { ID = s.ID, Name = s.Name }).ToList(),
					StopsInbound = transportationContext.RouteStops.Where(rs => rs.RouteID == r.ID && rs.Direction == Direction.Inbound).OrderBy(rs => rs.Order).Select(rs => rs.Stop).Select(s => new StopDto() { ID = s.ID, Name = s.Name }).ToList()
				});
			}
			else
				return new List<RouteDto>();
		}

		public IEnumerable<RouteDto> GetRoutesByStop(string stop)
		{
			Stop entity = transportationContext.Stops.FirstOrDefault(s => s.Name == stop);
			if(entity == null)
				throw new EntityNotFoundException("Stop not found with the specified name");
			else
				return GetRoutesByStopId(entity.ID);
		}

		public IEnumerable<RouteDto> GetRoutesByStopId(int stopId)
		{
			if(transportationContext.Stops.Any(s => s.ID == stopId))
			{
				return transportationContext.RouteStops.Where(rs => rs.StopID == stopId).Select(rs => rs.Route).Select(r => new RouteDto()
				{
					ID = r.ID,
					RouteNumber = r.RouteNumber,
					Provider = r.Provider,
					StopsOutbound = transportationContext.RouteStops.Where(rs => rs.RouteID == r.ID && rs.Direction == Direction.Outbound).OrderBy(rs => rs.Order).Select(rs => rs.Stop).Select(s => new StopDto() { ID = s.ID, Name = s.Name }).ToList(),
					StopsInbound = transportationContext.RouteStops.Where(rs => rs.RouteID == r.ID && rs.Direction == Direction.Inbound).OrderBy(rs => rs.Order).Select(rs => rs.Stop).Select(s => new StopDto() { ID = s.ID, Name = s.Name }).ToList()
				});
			}
			else
				throw new EntityNotFoundException("Stop not found with the specified ID");
		}

		public void UpdateRoute(int id, RouteDto route)
		{
			throw new NotImplementedException();
		}
	}
}
