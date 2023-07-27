using Tumbleweed.Number.Real.Binary.Precision.Single.From.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics.Rounding;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics.Rounding.Nearest;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics.Rounding.Nearest.As;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From;
using One = Tumbleweed.Number.Real.Binary.Precision.Single.From.System.One;


namespace Tumbleweed.Number.Real.Arithmetic.Rounding;

public sealed class NearestIntegerOfReal : Envelope
{
	public NearestIntegerOfReal(Any real) : base
	(
		new One(
			new Binary.Precision.Single.System.Arithmetics.Rounding.Nearest.As.Real(
				new Binary.Precision.Single.System.From.Tumbleweed.One(real)))
	)
	{
	}
}