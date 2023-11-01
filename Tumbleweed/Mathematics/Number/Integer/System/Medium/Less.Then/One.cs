using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.Less.Then;

public sealed class One : Envelope<Int32>
{
	public One
	(
		Any<Int32> less,
		Any<Int32> more
	) : base
	(
		new Actual<Int32>(
			() => Function(less, more))
	)
	{
	}

	private static Int32 Function
	(
		Any<Int32> less,
		Any<Int32> more
	)
	{
		if (less.Value < more.Value) return less.Value;
		throw new InvalidOperationException("Value is greater then max");
	}
}