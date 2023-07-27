using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.System.Medium.Difference;

public sealed class Two : TW.Scalar.Envelope<Int32>
{
	public Two
	(
		TW.Scalar.Any<Int32> left,
		TW.Scalar.Any<Int32> right
	) : base
	(
		new TW.Scalar.Function.Result<Int32>(
			() => left.Value - right.Value)
	)
	{
	}
}