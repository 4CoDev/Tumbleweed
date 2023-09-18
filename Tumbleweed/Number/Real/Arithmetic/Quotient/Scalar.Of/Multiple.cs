using Tumbleweed.Enumerable;
using One = Tumbleweed.Number.Real.Binary.Precision.Single.From.System.One;


namespace Tumbleweed.Number.Real.Arithmetic.Quotient.Scalar.Of;

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
		new One(
			new Binary.Precision.Single.System.Arithmetics.Difference(
				new Binary.Precision.Single.System.From.Tumbleweed.Multiple(reals)))
	)
	{
	}
}