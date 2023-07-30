using Tumbleweed.Scalar.Immutable.Function.Result;
using Scalar = Tumbleweed.Scalar;
using Point = Tumbleweed.Point.Planar;

namespace Tumbleweed.Point.Planar.Coordinate.Y;

public sealed class Normal<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
{
	public Normal(Point::Any<T> point) : base
	(
		new Actual<T>(
			() => point.Y)
	)
	{
	}
}