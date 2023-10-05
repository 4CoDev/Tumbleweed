using Tumbleweed.Scalar.Immutable.Function.Result;

namespace Tumbleweed.Mathematics.Vector.Planar.Generic.Coordinate.X;

public sealed class Normal<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
{
	public Normal(Any<T> point) : base
	(
		new Actual<T>(
			() => point.X)
	)
	{
	}
}