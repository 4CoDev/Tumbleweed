using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Spatial.Real.With.Coordinate.Definition;

public sealed class Uniform : Point::Generic.Envelope<Real::Any>
{
	public Uniform(Real::Any coordinate) : base
	(
		new Point::Real.With.Coordinate.Definition.Unique(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}