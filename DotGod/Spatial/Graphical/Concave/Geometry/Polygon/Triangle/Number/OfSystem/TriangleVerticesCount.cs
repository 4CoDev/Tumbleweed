using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.Number.OfSystem;

public sealed class TriangleVerticesCount : Envelope<Int32>
{
	public TriangleVerticesCount() : base
	(
		new Value<Int32>(3)
	)
	{
	}
}