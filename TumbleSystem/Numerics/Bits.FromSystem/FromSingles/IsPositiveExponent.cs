using TumbleSystem.Bits.FromEnumerable;
using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Bits.FromSystem.FromSingles;

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