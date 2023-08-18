using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using SCG = System.Collections.Generic;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using Mesh = DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot;
using Vector = DotGod.Vector.Spatial;

namespace DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot.With.Vertex.
	Translation.Point.Enumerable;

public sealed class Actual : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public Actual
	(
		SCG::IEnumerable<Point::Any<Real::Any>> translations
	) : base
	(
		new Mesh::With.Vertex.Translation.Vector.Enumerable.Actual(
			new Vector::From.Point.Enumerable(translations))
	)
	{
	}
}