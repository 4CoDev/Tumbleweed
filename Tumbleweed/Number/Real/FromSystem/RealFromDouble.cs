using Tumbleweed.Number.Integer.Signed.FromSystem;
using Tumbleweed.Number.Real.Binary.FromSystem.FromDouble.Exponent;
using Tumbleweed.Number.Real.Binary.FromSystem.FromDouble.Mantissa;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.FromSystem;

public sealed class RealFromDouble : RealEnvelope
{
	public RealFromDouble(Double @double) : this
	(
		new ScalarValue<Double>(@double)
	)
	{
	}

	public RealFromDouble(IScalar<Double> @double) : base
	(
		new RealWithValues(
			new MantissaOfDouble(@double),
			new BaseOfDouble(),
			new ExponentOfDouble(@double))
	)
	{
	}
}