﻿using Newtonsoft.Json;

namespace Nest
{
	public interface IIndexResponse : IResponse
	{
		string Id { get; }
		string Index { get; }
		string Type { get; }
		long Version { get; }
		Result Result { get; }
		ShardsMetadata Shards { get; }
		long SequenceNumber { get; }
		long PrimaryTerm { get; }
	}

	[JsonObject]
	public class IndexResponse : ResponseBase, IIndexResponse
	{
		[JsonProperty("_index")]
		public string Index { get; internal set; }

		[JsonProperty("_type")]
		public string Type { get; internal set; }

		[JsonProperty("_id")]
		public string Id { get; internal set; }

		[JsonProperty("_version")]
		public long Version { get; internal set; }

		[JsonProperty("result")]
		public Result Result { get; internal set; }

		[JsonProperty("_shards")]
		public ShardsMetadata Shards { get; internal set; }

		[JsonProperty("_seq_no")]
		public long SequenceNumber { get; internal set; }

		[JsonProperty("_primary_term")]
		public long PrimaryTerm { get; internal set; }

	}
}
