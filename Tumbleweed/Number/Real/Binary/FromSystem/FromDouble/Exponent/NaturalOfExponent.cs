using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromDouble.Exponent;

public sealed class NaturalOfExponent : NaturalEnvelope
{
	public NaturalOfExponent(IScalar<Double> @double) : base
	(
		new NaturalWithBits(
			new BitsOfExponent(@double))
	)
	{
	}
}