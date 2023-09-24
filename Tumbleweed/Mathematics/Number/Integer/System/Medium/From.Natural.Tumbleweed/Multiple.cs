using Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;

public sealed class Multiple : Envelope<Int32>
{
	public Multiple(params global::Tumbleweed.Mathematics.Number.Natural.Any[] numbers) : this
	(
		new Concatenated<global::Tumbleweed.Mathematics.Number.Natural.Any>(numbers)
	)
	{
	}

	public Multiple(IEnumerable<global::Tumbleweed.Mathematics.Number.Natural.Any> numbers) : base
	(
		new Selected<global::Tumbleweed.Mathematics.Number.Natural.Any, Int32>(
			numbers,
			number => new global::Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed.One(number).Value)
	)
	{
	}

}