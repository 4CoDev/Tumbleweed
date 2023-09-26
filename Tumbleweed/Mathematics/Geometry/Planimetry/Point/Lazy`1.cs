using Tumbleweed.Mathematics.Geometry.Planimetry.Point.With.Coordinate.Definition;
using Point = Tumbleweed.Point.Planar;

namespace Tumbleweed.Mathematics.Geometry.Planimetry.Point;

public sealed class Lazy<T> : Envelope<T>
{
	public Lazy(Any<T> point) : base
	(
		new Unique<T>(
			new Coordinate.X.Lazy<T>(point),
			new Coordinate.Y.Lazy<T>(point))
	)
	{
	}
}