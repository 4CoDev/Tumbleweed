using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32;

public class DifferenceOfTwoInts32 : ScalarEnvelope<int>
{
	public DifferenceOfTwoInts32
	(
		IScalar<int> left,
		IScalar<int> right
	) : base
	(
		new ValueOfDelegate<int>(
			() => left.Value - right.Value)
	)
	{
	}
}