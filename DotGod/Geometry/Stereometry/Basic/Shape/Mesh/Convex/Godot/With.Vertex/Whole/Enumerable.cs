using DotGod.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Translation.Point.Enumerable;
using Tumbleweed.Geometry.Stereometry.Vertex;
using Tumbleweed.Geometry.Stereometry.Vertex.Member.Translation;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using SCG = System.Collections.Generic;

namespace DotGod.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Whole;

public sealed class Enumerable : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public Enumerable
	(
		SCG::IEnumerable<Any> vertices
	) : base
	(
		new Actual(
			new Multiple(vertices))
	)
	{
	}
}