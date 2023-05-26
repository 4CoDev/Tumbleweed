using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Signed.OfSystem._Int32;

public class DifferenceOfTwoInts32 : ScalarEnvelope<Int32>
{
	public DifferenceOfTwoInts32
	(
		IScalar<Int32> left,
		IScalar<Int32> right
	) : base
	(
		new ResultOfFunction<Int32>(
			() => left.Value - right.Value)
	)
	{
	}
}