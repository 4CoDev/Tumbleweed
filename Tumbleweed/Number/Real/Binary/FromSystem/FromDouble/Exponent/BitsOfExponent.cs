using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed._Enumerable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromDouble.Exponent;

public sealed class BitsOfExponent : EnumerableEnvelope<IBoolean>
{
	public BitsOfExponent(IScalar<Double> @double) : base
	(
		new ElementsFromMiddle<IBoolean>(
			new BitsOfDouble(@double), 52, 61)
	)
	{
	}
}