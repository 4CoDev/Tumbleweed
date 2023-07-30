using Tumbleweed.Scalar.Immutable.From.Enumerable;
using TW = Tumbleweed;

namespace Tumbleweed.Boolean.From.Enumerable;

public sealed class Last : Envelope
{
	public Last(IEnumerable<Any> enumerable) : base
	(
		new Boolean.Scalar.Value(
			new Last<Any>(enumerable))
	)
	{
	}
}