
using Tumbleweed.Enumerable.With.Length.Statement;
using Tumbleweed.Scalar.From.Enumerable.At.Index;

namespace Tumbleweed.Scalar.From.Enumerable;

public sealed class Single<T> : Scalar.Envelope<T>
{
	public Single
	(
		IEnumerable<T> enumerable
	) : base
	(
		new At.Index.System<T>(
			new Tumbleweed.Enumerable.With.Length.Statement.System<T>(enumerable, 1),
			0)
	)
	{
	}
}