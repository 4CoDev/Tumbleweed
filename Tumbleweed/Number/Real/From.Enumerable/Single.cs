using Tumbleweed.Number.Real.Scalar;
using Tumbleweed.Scalar.Immutable.From.Enumerable;

namespace Tumbleweed.Number.Real.From.Enumerable;

public sealed class Single : Envelope
{
	public Single(IEnumerable<Any> enumerable) : base
	(
		new Value(
			new Single<Any>(enumerable))
	)
	{
	}
}