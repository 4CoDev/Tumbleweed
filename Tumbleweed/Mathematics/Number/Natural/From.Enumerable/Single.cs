using Tumbleweed.Scalar.Immutable.From.Enumerable;

namespace Tumbleweed.Mathematics.Number.Natural.From.Enumerable;

public sealed class Single : Tumbleweed.Mathematics.Number.Natural.Envelope
{
	public Single
	(
		IEnumerable<Any> enumerable
	) : base
	(
		new Tumbleweed.Mathematics.Number.Natural.Scalar.Value(
			new Single<Any>(
				enumerable))
	)
	{
	}
}