using Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Tumbleweed;

public sealed class Multiple : Envelope<Int32>
{
	public Multiple(params global::Tumbleweed.Mathematics.Number.Integer.Any[] integers) : this
	(
		new Concatenated<global::Tumbleweed.Mathematics.Number.Integer.Any>(integers)
	)
	{
	}

	public Multiple(IEnumerable<global::Tumbleweed.Mathematics.Number.Integer.Any> integers) : base
	(
		new Selected<global::Tumbleweed.Mathematics.Number.Integer.Any, Int32>(
			integers,
			integer => new global::Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Tumbleweed.One(integer).Value)
	)
	{
	}

}