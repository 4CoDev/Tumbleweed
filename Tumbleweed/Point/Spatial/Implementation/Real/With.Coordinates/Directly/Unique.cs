using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Spatial.Implementation.Real.With.Coordinates.Directly;

public sealed class Unique : Point::Envelope<Real::Any>
{
	public Unique
	(
		Real::Any x,
		Real::Any y,
		Real::Any z
	) : base
	(
		new Point::With.Coordinates.Unique<Real::Any>(x, y, z)
	)
	{
	}
}