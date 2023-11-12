using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Number.Real;
using Envelope = Tumbleweed.Mathematics.Number.Real.Envelope;
using Number = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single;


namespace Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Quotient.Scalar.Of;

public sealed class Multiple : Envelope
{
	public Multiple(params Any[] reals) : this
	(
		new Concatenated<Any>(reals)
	)
	{
	}
	
	public Multiple(IEnumerable<Any> reals) : base
	(
		new Number::From.System.One(
			new Number::System.Arithmetics.Quotient(
				new Number::System.From.Tumbleweed.Multiple(reals)))
	)
	{
	}
}