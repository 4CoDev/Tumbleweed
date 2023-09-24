using Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;
using Single = Tumbleweed.Point.Spatial.Real.Base.Binary.Precision.Single;

namespace Tumbleweed.Point.Spatial.Real.Literal;

public sealed class Unit : Point::Generic.Envelope<Any>
{
	public Unit() : base
	(
		new Single::With.Coordinate.System.Definition.Uniform(1)
	)
	{
	}
}