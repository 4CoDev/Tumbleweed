using Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics;


namespace Tumbleweed.Number.Real.Arithmetic.Negation.Of;

public sealed class One : Envelope
{
	public One(Any real) : base
	(
		new Binary.Precision.Single.From.System.One(
			new Negative(
				new Binary.Precision.Single.System.From.Tumbleweed.One(real)))
	)
	{
	}
}