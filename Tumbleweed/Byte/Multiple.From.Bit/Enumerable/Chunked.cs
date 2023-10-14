using Tumbleweed.Byte.One.From.Bit.Collection;
using Tumbleweed.Enumerable;

namespace Tumbleweed.Byte.Multiple.From.Bit.Enumerable;

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