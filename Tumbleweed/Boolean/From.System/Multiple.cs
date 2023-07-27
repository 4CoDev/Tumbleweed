using Tumbleweed.Enumerable;

namespace Tumbleweed.Boolean.From.System;

public sealed class Multiple : Envelope<Any>
{
	public Multiple(IEnumerable<global::System.Boolean> booleans) : base
	(
		new Selected<global::System.Boolean, Any>(
			booleans,
			boolean => new One(boolean)
		)
	)
	{
	}
}