using Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Point.Spatial.Real.With.Coordinate.Definition;

public sealed class Uniform : Point::Generic.Envelope<Any>
{
	public Uniform(Any coordinate) : base
	(
		new Point::Real.With.Coordinate.Definition.Unique(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}