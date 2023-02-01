using TumbleSystem.Enumerables;
using Tumbleweed.Bits;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Bits.FromSystem.FromSingles;

public sealed class ExponentOfSingle : IntegerEnvelope
{
	public ExponentOfSingle(IScalar<float> @float) : base
	(
		new IntegerWithValues(
			new IsPositiveExponent(@float),
			new ElementsFromMiddle<IBit>(
				new BitsOfSingle(@float), 23, 29))
	)
	{
	}
}