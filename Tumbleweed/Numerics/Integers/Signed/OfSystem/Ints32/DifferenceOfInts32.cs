using Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32.FromEnumerable;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32;

public sealed class DifferenceOfInts32 : ScalarEnvelope<int>
{
	public DifferenceOfInts32(IEnumerable<IScalar<int>> numbers) : base
	(
		new AggregatedByExpression(
			numbers,
			new ScalarOfValue<int>(0),
			(left, right) =>
				new DifferenceOfTwoInts32(left, right))
	)
	{
	}
}