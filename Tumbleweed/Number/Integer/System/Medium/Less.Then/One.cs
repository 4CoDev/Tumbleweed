using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.System.Medium.Less.Then;

public sealed class One : TW.Scalar.Envelope<Int32>
{
	public One
	(
		TW.Scalar.Any<Int32> less,
		TW.Scalar.Any<Int32> more
	) : base
	(
		new TW.Scalar.Function.Result<Int32>(
			() => Function(less, more))
	)
	{
	}

	private static Int32 Function
	(
		TW.Scalar.Any<Int32> less,
		TW.Scalar.Any<Int32> more
	)
	{
		if (less.Value < more.Value) return less.Value;
		throw new InvalidOperationException("Value is greater then max");
	}
}