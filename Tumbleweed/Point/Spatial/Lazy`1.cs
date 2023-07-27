using Point = Tumbleweed.Point.Spatial;
using Coordinate = Tumbleweed.Point.Spatial.Coordinate;

namespace Tumbleweed.Point.Spatial;

public sealed class Lazy<T> : Point::Envelope<T>
{
	public Lazy(Point::Any<T> point) : base
	(
		new Point::With.Coordinates.Unique<T>(
			new Coordinate::X.Lazy.One<T>(point),
			new Coordinate::Y.Lazy.One<T>(point),
			new Coordinate::Z.Lazy.One<T>(point))
	)
	{
	}
}