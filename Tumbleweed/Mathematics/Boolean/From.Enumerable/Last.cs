using Tumbleweed.Scalar.Immutable.From.Enumerable;

namespace Tumbleweed.Mathematics.Boolean.From.Enumerable;

public sealed class Last : Envelope
{
	public Last(IEnumerable<Any> enumerable) : base
	(
		new Tumbleweed.Boolean.Scalar.Value(
			new Last<Any>(enumerable))
	)
	{
	}
}