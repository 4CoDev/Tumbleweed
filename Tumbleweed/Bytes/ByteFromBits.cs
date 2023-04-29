using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;

namespace Tumbleweed.Bytes;

public sealed class ByteFromBits : EnumerableEnvelope<IBoolean>
{
	public ByteFromBits(IEnumerable<IBoolean> bits) : this
	(
		new List<IBoolean>(bits)
	)
	{
	}

	public ByteFromBits(ICollection<IBoolean> bits) : base
	(
		new EnumerableOfFunction<IBoolean>(() =>
		{
			if (bits.Count <= 8) return bits;
			throw new ArgumentException("Byte doesn't have more than 8 bits");
		})
	)
	{
	}
}