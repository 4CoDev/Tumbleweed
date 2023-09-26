using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Base.Binary.Precision.Single.With.Coordinate.System.Definition;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.With.Vertex.Translation.Array;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Cube.Mesh.With.Origin.Corner.Bottom.Left.Literal;

public sealed class Unit : Envelope
{
	public Unit() : base
	(
		new One(
			new Uniform(0),
			new Unique(1, 0, 0),
			new Unique(0, 1, 0),
			new Unique(1, 1, 0),
			new Unique(0, 0, 1),
			new Unique(1, 0, 1),
			new Unique(0, 1, 1),
			new Uniform(1))
	)
	{
	}
}