using Tumbleweed.Mathematics.Boolean.From.System;

namespace Tumbleweed.Mathematics.Boolean.Literal;

public sealed class True : Envelope
{
	public True() : base
	(
		new One(true)
	)
	{
	}
}