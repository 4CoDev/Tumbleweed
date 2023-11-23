using Tumbleweed.Enumerable;
using Tumbleweed.Information.Measurement.Byte.One.From.Bit.Collection;

namespace Tumbleweed.Information.Measurement.Byte.Multiple.From.Bit.Enumerable;

public sealed class Chunked
	: Envelope<IEnumerable<Mathematics.Boolean.Any>>
{
	public Chunked(IEnumerable<IEnumerable<Mathematics.Boolean.Any>> bytes) : base
	(
		new Selected<IEnumerable<Mathematics.Boolean.Any>>(
			bytes,
			@byte => new Actual(@byte))
	)
	{
	}
}