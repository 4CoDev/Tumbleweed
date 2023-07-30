using Tumbleweed.Scalar.Immutable.From.Enumerable;
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
			new Single<Integer.Any>(enumerable))
	)
	{
	}
}