using Tumbleweed.Enumerable;

namespace Tumbleweed.Number.Integer.From.System;

public class Multiple : Envelope<Integer.Any>
{
	public Multiple
	(
		params global::System.Int32[] integers
	) : this
	(
		new Concatenated<Int32>(integers)
	)
	{
	}

	public Multiple
	(
		IEnumerable<global::System.Int32> integers
	) : base
	(
		new Selected<global::System.Int32, Integer.Any>(
			integers,
			integer => new Integer.From.System.One(integer))
	)
	{
	}
}