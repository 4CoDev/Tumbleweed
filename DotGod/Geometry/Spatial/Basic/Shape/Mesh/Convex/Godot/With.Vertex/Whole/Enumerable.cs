using DotGod.Geometry.Spatial.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Translation.Point.Enumerable;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace DotGod.Geometry.Spatial.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Whole;

public sealed class Enumerable : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public Enumerable
	(
		SCG::IEnumerable<Vertex::Any> vertices
	) : base
	(
		new Actual(
			new Vertex::Member.Translation.Multiple(vertices))
	)
	{
	}
}