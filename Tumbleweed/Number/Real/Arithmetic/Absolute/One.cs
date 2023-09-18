namespace Tumbleweed.Number.Real.Arithmetic.Absolute;

public sealed class One : Envelope
{
	public One(Any real) : base
	(
		new Binary.Precision.Single.From.System.One(
			new Binary.Precision.Single.System.Arithmetics.Absolute(
				new Binary.Precision.Single.System.From.Tumbleweed.One(real)))
	)
	{
	}
}