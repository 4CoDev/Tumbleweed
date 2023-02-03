using Tumbleweed.Numerics.Integers.OfSystem.Ints32.FromEnumerable;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.OfSystem.Ints32;

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