using Tumbleweed.Boolean.From.System;
using Tumbleweed.Boolean.System.Function;

namespace Tumbleweed.Boolean;

public sealed class Not : Envelope
{
	public Not(Boolean.Any boolean) : base
	(
		new One(
			new Result(
				() => !boolean.State))
	)
	{
	}
}