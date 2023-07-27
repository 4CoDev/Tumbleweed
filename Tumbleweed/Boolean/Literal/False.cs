using Tumbleweed.Boolean.From.System;

namespace Tumbleweed.Boolean.Literal;

public sealed class False : Envelope
{
	public False() : base
	(
		new One(false)
	)
	{
	}
}