using Point = Tumbleweed.Point.Planar;
using Coordinate = Tumbleweed.Point.Planar.Coordinate;

namespace Tumbleweed.Point.Planar;

public sealed class Lazy<T> : Point::Envelope<T>
{
	public Lazy(Point::Any<T> point) : base
	(
		new Point::With.Coordinates<T>(
			new Coordinate::X.Lazy<T>(point),
			new Coordinate::Y.Lazy<T>(point))
	)
	{
	}
}