using Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Tumbleweed.Number.Natural;

namespace Tumbleweed.Scalar.From.Enumerable.At.Index;

public sealed class Tumbleweed<T> : Scalar.Envelope<T>
{
	public Tumbleweed
	(
		IEnumerable<T> enumerable,
		Any index
	) : base
	(
		new At.Index.System<T>(
			enumerable,
			new One(index))
	)
	{
	}
}