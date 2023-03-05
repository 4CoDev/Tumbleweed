using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32;

public class DifferenceOfTwoInts32 : ScalarEnvelope<Int32>
{
	public DifferenceOfTwoInts32
	(
		IScalar<Int32> left,
		IScalar<Int32> right
	) : base
	(
		new ValueOfDelegate<Int32>(
			() => left.Value - right.Value)
	)
	{
	}
}