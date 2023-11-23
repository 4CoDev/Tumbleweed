using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;
using Tumbleweed.Mathematics.Boolean.System.Function.Result;


namespace Tumbleweed.Mathematics.Comparison.Boolean.Both.Are;

public sealed class Equal : Envelope
{
	public Equal
	(
		Mathematics.Boolean.Any first,
		Mathematics.Boolean.Any second
	) : base
	(
		new One(
			new Actual(
				() => first.State == second.State))
	)
	{
	}
}