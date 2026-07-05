using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace GROAN.Business
{
	public class DataListResponse
	{
		[JsonPropertyName("results")]
		public IEnumerable<DataResponse> DataResponses { get; set; }
	}
}