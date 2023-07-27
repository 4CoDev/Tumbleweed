using TW = Tumbleweed;

namespace Tumbleweed.Boolean.From.Enumerable;

public sealed class Last : Envelope
{
	public Last(IEnumerable<Any> enumerable) : base
	(
		new Boolean.Scalar.Value(
			new TW.Scalar.From.Enumerable.Last<Any>(enumerable))
	)
	{
	}
}