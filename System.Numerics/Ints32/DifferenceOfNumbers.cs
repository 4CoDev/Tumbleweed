using Tumbleweed.Scalars;
using Tumbleweed.System.Numerics.Ints32.FromEnumerable;

namespace Tumbleweed.System.Numerics.Ints32;

public sealed class DifferenceOfNumbers : ScalarEnvelope<int>
{
	public DifferenceOfNumbers(IEnumerable<IScalar<int>> numbers) : base
	(
		new AggregatedByExpression(
			numbers,
			new ScalarOfValue<int>(0),
			(left, right) =>
				new DifferenceOf2Numbers(left, right))
	)
	{
	}
}