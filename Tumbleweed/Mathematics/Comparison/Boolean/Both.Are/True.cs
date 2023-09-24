using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;
using Boolean = Tumbleweed.Boolean;

namespace Tumbleweed.Mathematics.Comparison.Boolean.Both.Are;

public sealed class True : Envelope
{
	public True
	(
		Mathematics.Boolean.Any first,
		Mathematics.Boolean.Any second
	) : base
	(
		new One(
			new Boolean::System.Function.Result(
				() => first.State && second.State))
	)
	{
	}
}