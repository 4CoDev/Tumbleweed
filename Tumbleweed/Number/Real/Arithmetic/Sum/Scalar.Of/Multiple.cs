using Tumbleweed.Enumerable;
using One = Tumbleweed.Number.Real.Binary.Precision.Single.From.System.One;


namespace Tumbleweed.Number.Real.Arithmetic.Sum.Scalar.Of;

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
			new Binary.Precision.Single.System.Arithmetics.Sum(
				new Binary.Precision.Single.System.From.Tumbleweed.Multiple(summands)))
	)
	{
	}
}