using Tumbleweed.Property.Output;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Enumerable;

public sealed class Aggregated : Envelope<Int32>
{
	public Aggregated
	(
		IEnumerable<Any<Int32>> from,
		Any<Int32> seed,
		Func<Any<Int32>, Any<Int32>, Any<Int32>>
			expression
	) : base
	(
		new Aggregated<Any<Int32>>(from, seed, expression)
	)
	{
	}
}