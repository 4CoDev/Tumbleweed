using Tumbleweed.Mathematics.Boolean.From.System;

namespace Tumbleweed.Mathematics.Boolean.Literal;

public sealed class False : Envelope
{
	public False() : base
	(
		new One(false)
	)
	{
	}
}