using Scalar = Tumbleweed.Scalar;
using Point = Tumbleweed.Point.Planar;

namespace Tumbleweed.Point.Planar.Coordinate.X;

public sealed class Lazy<T> : Scalar::Envelope<T>
{
	public Lazy(Point::Any<T> point) : base
	(
		new Scalar::Lazy.OfValue<T>(
			new Normal<T>(point))
	)
	{
	}
}