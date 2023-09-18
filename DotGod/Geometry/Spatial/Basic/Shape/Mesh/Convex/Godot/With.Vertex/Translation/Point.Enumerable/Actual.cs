using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using SCG = System.Collections.Generic;
using Real = Tumbleweed.Number.Real;
using Vector = DotGod.Vector.Spatial;

namespace DotGod.Geometry.Spatial.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Translation.Point.Enumerable;

public sealed class Actual : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public Actual
	(
		SCG::IEnumerable<global::Tumbleweed.Point.Spatial.Generic.Any<Real::Any>> translations
	) : base
	(
		new Vector.Enumerable.Actual(
			new Vector::From.Point.Enumerable(translations))
	)
	{
	}
}