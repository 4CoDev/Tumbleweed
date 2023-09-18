using Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex;
using Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.With.Vertex.Translation.Array;
using Point = Tumbleweed.Point.Spatial.Real.Base.Binary.Precision.Single;

namespace Tumbleweed.Geometry.Spatial.Shape.Parametric.Cube.Mesh.With.Origin.Corner.Bottom.Left.Literal;

public sealed class Unit : Envelope
{
	public Unit() : base
	(
		new One(
			new Point::With.Coordinate.System.Definition.Uniform(0),
			new Point::With.Coordinate.System.Definition.Unique(1, 0, 0),
			new Point::With.Coordinate.System.Definition.Unique(0, 1, 0),
			new Point::With.Coordinate.System.Definition.Unique(1, 1, 0),
			new Point::With.Coordinate.System.Definition.Unique(0, 0, 1),
			new Point::With.Coordinate.System.Definition.Unique(1, 0, 1),
			new Point::With.Coordinate.System.Definition.Unique(0, 1, 1),
			new Point::With.Coordinate.System.Definition.Uniform(1))
	)
	{
	}
}