using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed._Enumerable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromDouble.Mantissa;

public sealed class BitsOfMantissa : EnumerableEnvelope<IBoolean>
{
	public BitsOfMantissa(Double @double) : this
	(
		new ScalarValue<Double>(@double)
	)
	{
	}
	
	public BitsOfMantissa(IScalar<Double> @double) : base
	(
		new ElementsFromLeft<IBoolean>(
			new BitsOfDouble(@double),
			new MantissaSize())
	)
	{
	}
}