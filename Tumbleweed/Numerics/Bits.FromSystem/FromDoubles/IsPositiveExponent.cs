using Tumbleweed.Bits;
using Tumbleweed.Bits.FromEnumerable.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem.FromDoubles;

public sealed class IsPositiveExponent : BitEnvelope
{
	public IsPositiveExponent(IScalar<double> @double) : base
	(
		new BitAtIndex(
			new BitsOfDouble(@double),
			62)
	)
	{
	}
}