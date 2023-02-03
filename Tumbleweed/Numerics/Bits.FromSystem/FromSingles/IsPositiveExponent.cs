using Tumbleweed.Bits;
using Tumbleweed.Bits.FromEnumerable.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem.FromSingles;

public sealed class IsPositiveExponent : BitEnvelope
{
	public IsPositiveExponent(IScalar<float> @float) : base
	(
		new BitAtIndex(
			new BitsOfSingle(@float),
			30)
	)
	{
	}
}