using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Number.Real;
using Envelope = Tumbleweed.Mathematics.Number.Real.Envelope;
using One = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.From.System.One;


namespace Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Sum.Scalar.Of;

public sealed class Multiple : Envelope
{
	public Multiple(params Any[] summands) : this
	(
		new Concatenated<Any>(summands)
	)
	{
	}
	
	public Multiple(IEnumerable<Any> summands) : base
	(
		new One(
			new Number.Real.Binary.Precision.Single.System.Arithmetics.Sum(
				new Number.Real.Binary.Precision.Single.System.From.Tumbleweed.Multiple(summands)))
	)
	{
	}
}