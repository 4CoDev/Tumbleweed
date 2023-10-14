using Tumbleweed.Mathematics.Boolean.Scalar.Value;
using Tumbleweed.Scalar.Immutable.From.Enumerable;

namespace Tumbleweed.Mathematics.Boolean.From.Enumerable;

public sealed class Last : Envelope
{
	public Last(IEnumerable<Any> enumerable) : base
	(
		new Actual(
			new Last<Any>(enumerable))
	)
	{
	}
}