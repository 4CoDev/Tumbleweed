using Scalar = Tumbleweed.Scalar;
using Point = Tumbleweed.Point.Planar;

namespace Tumbleweed.Point.Planar.Coordinate.X;

public sealed class Lazy<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
{
	public Lazy(Point::Any<T> point) : base
	(
		new Tumbleweed.Scalar.Immutable.Lazy<T>(
			new Normal<T>(point))
	)
	{
	}
}