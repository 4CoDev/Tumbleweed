using Tumbleweed.Boolean.System.Function;
using Tumbleweed.Mathematics.Boolean.From.System;

namespace Tumbleweed.Mathematics.Boolean;

public sealed class Not : Envelope
{
	public Not(Any boolean) : base
	(
		new One(
			new Result(
				() => !boolean.State))
	)
	{
	}
}