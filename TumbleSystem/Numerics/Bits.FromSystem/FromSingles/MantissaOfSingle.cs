using TumbleSystem.Enumerables;
using Tumbleweed.Bits;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Bits.FromSystem.FromSingles;

public sealed class MantissaOfSingle : IntegerEnvelope
{
	public MantissaOfSingle(IScalar<float> @float) : base
	(
		new IntegerWithValues(
			new IsPositiveMantissa(@float),
			new ElementsFromLeft<IBit>(
				new BitsOfSingle(@float),
				new MantissaSize()))
	)
	{
	}
}