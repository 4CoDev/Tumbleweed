using Tumbleweed.Mathematics.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using SCG = System.Collections.Generic;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Translation.Point.Enumerable;

public sealed class Actual : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public Actual
	(
		SCG::IEnumerable<global::Tumbleweed.Mathematics.Vector.Spatial.Generic.Any<Any>> translations
	) : base
	(
		new Vector.Enumerable.Actual(
			new Mathematics.Vector.Spatial.Godot.From.Tumbleweed.Enumerable(translations))
	)
	{
	}
}