using Bll.Dtos;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services.Impl
{
	public class RecordingService : IRecordingService
	{
		private readonly TransportationContext transportationContext;

		public RecordingService(TransportationContext transportationContext)
		{
			this.transportationContext = transportationContext;
		}

		public RecordingDto CreateNewRecording(RecordingDto recording)
		{
			throw new NotImplementedException();
		}

		public RecordingDto GetRecording(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<RecordingDto> GetRecordings()
		{
			throw new NotImplementedException();
		}
	}
}
