using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace Tumbleweed.Byte.One.From.Bit.Collection;

public sealed class Actual : Envelope<Mathematics.Boolean.Any>
{
	public Actual(IEnumerable<Mathematics.Boolean.Any> bits) : this
	(
		new List<Mathematics.Boolean.Any>(bits)
	)
	{
	}

	public Actual(ICollection<Mathematics.Boolean.Any> bits) : base
	(
		new Result<Mathematics.Boolean.Any>(() =>
		{
			if (bits.Count <= 8) return bits;
			throw new ArgumentException("Byte doesn't have more than 8 bits");
		})
	)
	{
	}
}