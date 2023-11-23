using Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Number.Natural.From.System;

public class Multiple : Envelope<Any>
{
	public Multiple(params Int32[] integers) : this
	(
		new Concatenated<Int32>(integers)
	)
	{
	}

	public Multiple(IEnumerable<Int32> integers) : base
	(
		new Selected<Int32, Any>(
			integers,
			integer => new One(integer))
	)
	{
	}
}