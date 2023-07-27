using Tumbleweed.Number.Real.Binary.Precision.Single.From.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Arithmetics;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From;
using One = Tumbleweed.Number.Real.Binary.Precision.Single.From.System.One;


namespace Tumbleweed.Number.Real.Arithmetic;

public sealed class AbsoluteReal : Envelope
{
	public AbsoluteReal(Any real) : base
	(
		new One(
			new Absolute(
				new Binary.Precision.Single.System.From.Tumbleweed.One(real)))
	)
	{
	}
}