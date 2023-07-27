using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.From.Enumerable;

public sealed class Single : Integer.Envelope
{
	public Single
	(
		IEnumerable<Integer.Any> enumerable
	) : base
	(
		new Integer.Scalar.Value(
			new TW.Scalar.From.Enumerable.Single<Integer.Any>(enumerable))
	)
	{
	}
}