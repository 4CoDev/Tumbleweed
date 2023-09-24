using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Arithmetic.Real.Absolute;

public sealed class One : Envelope
{
	public One(Any real) : base
	(
		new Number.Real.Binary.Precision.Single.From.System.One(
			new Number.Real.Binary.Precision.Single.System.Arithmetics.Absolute(
				new Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(real)))
	)
	{
	}
}