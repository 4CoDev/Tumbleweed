using Tumbleweed.Mathematics.Boolean.From.System;
using Tumbleweed.Mathematics.Boolean.System.Function.Result;

namespace Tumbleweed.Mathematics.Boolean;

public sealed class Not : Envelope
{
	public Not(Any boolean) : base
	(
		new One(
			new Actual(
				() => !boolean.State))
	)
	{
	}
}