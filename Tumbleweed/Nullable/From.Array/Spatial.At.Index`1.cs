using Tumbleweed.Array;
using INaturalPoint = Tumbleweed.Point.Spatial.Any<
		Tumbleweed.Number.Natural.Any>;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Nullable.From.Array.Spatial.At;

public sealed class Index<T> : Nullable.Envelope<T>
{
	public Index
	(Tumbleweed.Array.Any<Any<T>> array,
		INaturalPoint indices
	) : base
	(
		new Nullable.Of.Scalar<T>(
			new Scalar.From.Array.Spatial.At.Index<Nullable.Any<T>>(array, indices))
	)
	{
	}
}