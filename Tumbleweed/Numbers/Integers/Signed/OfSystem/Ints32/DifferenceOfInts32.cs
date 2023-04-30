using Tumbleweed.Numbers.Integers.Signed.OfSystem.Ints32.FromEnumerable;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed.OfSystem.Ints32;

public sealed class DifferenceOfInts32 : ScalarEnvelope<Int32>
{
	public DifferenceOfInts32(IEnumerable<IScalar<Int32>> numbers) : base
	(
		new AggregatedByExpression(
			numbers,
			new ScalarValue<Int32>(0),
			(left, right) =>
				new DifferenceOfTwoInts32(left, right))
	)
	{
	}
}