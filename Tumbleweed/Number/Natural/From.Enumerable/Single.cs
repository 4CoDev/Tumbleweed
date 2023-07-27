using TW = Tumbleweed;

namespace Tumbleweed.Number.Natural.From.Enumerable;

public sealed class Single : Natural.Envelope
{
	public Single
	(
		IEnumerable<Natural.Any> enumerable
	) : base
	(
		new Natural.Scalar.Value(
			new TW.Scalar.From.Enumerable.Single<Any>(
				enumerable))
	)
	{
	}
}