using Tumbleweed.Enumerable;

namespace Tumbleweed.Number.Natural.From.System;

public class Multiple : Envelope<Natural.Any>
{
	public Multiple(params Int32[] integers) : this
	(
		new Concatenated<Int32>(integers)
	)
	{
	}

	public Multiple(IEnumerable<Int32> integers) : base
	(
		new Selected<Int32, Natural.Any>(
			integers,
			integer => new Natural.From.System.One(integer))
	)
	{
	}
}