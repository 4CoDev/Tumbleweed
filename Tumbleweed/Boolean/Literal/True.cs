using Tumbleweed.Boolean.From.System;

namespace Tumbleweed.Boolean.Literal;

public sealed class True : Envelope
{
	public True() : base
	(
		new One(true)
	)
	{
	}
}