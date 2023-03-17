using Tumbleweed.Bits;
using Tumbleweed.Enumerables;

namespace Tumbleweed.Bytes;

public sealed class ByteFromBits : EnumerableEnvelope<IBit>
{
	public ByteFromBits(IEnumerable<IBit> bits) : this
	(
		new List<IBit>(bits)
	)
	{
	}

	public ByteFromBits(ICollection<IBit> bits) : base
	(
		new EnumerableOfFunction<IBit>(() =>
		{
			if (bits.Count <= 8) return bits;
			throw new ArgumentException("Byte doesn't have more than 8 bits");
		})
	)
	{
	}
}