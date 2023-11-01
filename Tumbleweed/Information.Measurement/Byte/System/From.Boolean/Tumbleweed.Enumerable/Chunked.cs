using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Item.Every.Property;
using Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Information.Measurement.Byte.System.From.Boolean.Tumbleweed.Enumerable;

public sealed class Chunked : global::Tumbleweed.Enumerable.Envelope<System::Byte>
{
	public Chunked(IEnumerable<IEnumerable<Mathematics.Boolean.Any>> bytes) : base
	(
		new Value<System::Byte>(
			new Selected<IEnumerable<Mathematics.Boolean.Any>, Any<System::Byte>>(
				bytes,
				@byte => new Linear(@byte)))
	)
	{
	}
}