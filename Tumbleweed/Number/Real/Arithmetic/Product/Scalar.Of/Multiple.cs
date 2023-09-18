using Tumbleweed.Enumerable;
using One = Tumbleweed.Number.Real.Binary.Precision.Single.From.System.One;

namespace Tumbleweed.Number.Real.Arithmetic.Product.Scalar.Of;

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
			new Binary.Precision.Single.System.Arithmetics.Difference(
				new Binary.Precision.Single.System.From.Tumbleweed.Multiple(factors)))
	)
	{
	}
}