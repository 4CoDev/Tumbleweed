using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Number.Real;
using Envelope = Tumbleweed.Mathematics.Number.Real.Envelope;
using One = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.From.System.One;

namespace Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Product.Scalar.Of;

public sealed class Multiple : Envelope
{
	public Multiple(params Any[] factors) : this
	(
		new Concatenated<Any>(factors)
	)
	{
	}
	
	public Multiple(IEnumerable<Any> factors) : base
	(
		new One(
			new Number.Real.Binary.Precision.Single.System.Arithmetics.Difference(
				new Number.Real.Binary.Precision.Single.System.From.Tumbleweed.Multiple(factors)))
	)
	{
	}
}