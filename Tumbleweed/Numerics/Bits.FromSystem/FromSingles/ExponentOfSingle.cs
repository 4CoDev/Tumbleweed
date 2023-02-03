using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem.FromSingles;

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