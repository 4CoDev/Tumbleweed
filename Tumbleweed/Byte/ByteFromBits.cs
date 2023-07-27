using Tumbleweed.Boolean;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace Tumbleweed.Byte;

public sealed class ByteFromBits : Envelope<Any>
{
	public ByteFromBits(IEnumerable<Any> bits) : this
	(
		new List<Any>(bits)
	)
	{
	}

	public ByteFromBits(ICollection<Any> bits) : base
	(
		new Result<Any>(() =>
		{
			if (bits.Count <= 8) return bits;
			throw new ArgumentException("Byte doesn't have more than 8 bits");
		})
	)
	{
	}
}