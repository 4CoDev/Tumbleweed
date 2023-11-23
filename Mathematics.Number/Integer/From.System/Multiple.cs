using Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Number.Integer.From.System;

public class Multiple : Envelope<Any>
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
		new Selected<global::System.Int32, Any>(
			integers,
			integer => new One(integer))
	)
	{
	}
}