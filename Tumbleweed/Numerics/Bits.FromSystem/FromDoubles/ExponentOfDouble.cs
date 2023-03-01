using Tumbleweed.Bits;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem.FromDoubles;

public sealed class ExponentOfDouble : SignedEnvelope
{
	public ExponentOfDouble(IScalar<double> @float) : base
	(
		new SignedWithValues(
			new IsPositiveExponent(@float),
			new ElementsFromMiddle<IBit>(
				new BitsOfDouble(@float), 52, 61))
	)
	{
	}
}