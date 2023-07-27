using Tumbleweed.Enumerable;

namespace Tumbleweed.Number.Integer.System.Medium.From.Tumbleweed;

public sealed class Multiple : Envelope<Int32>
{
	public Multiple(params Integer.Any[] integers) : this
	(
		new Concatenated<Integer.Any>(integers)
	)
	{
	}

	public Multiple(IEnumerable<Integer.Any> integers) : base
	(
		new Selected<Integer.Any, Int32>(
			integers,
			integer => new Medium.From.Tumbleweed.One(integer).Value)
	)
	{
	}

}