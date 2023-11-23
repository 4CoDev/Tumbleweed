using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;
using Tumbleweed.Mathematics.Boolean.System.Function.Result;


namespace Tumbleweed.Mathematics.Comparison.Boolean.Either.Is;

public sealed class True : Envelope
{
	public True
	(
		Mathematics.Boolean.Any first,
		Mathematics.Boolean.Any second
	) : base
	(
		new One(
			new Actual(
				() => first.State || second.State))
	)
	{
	}
}