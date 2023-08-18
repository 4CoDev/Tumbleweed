using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using Mesh = DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot;

namespace DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot.With.Vertex.Whole;

public sealed class Enumerable : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public Enumerable
	(
		SCG::IEnumerable<Vertex::Any> vertices
	) : base
	(
		new Mesh::With.Vertex.Translation.Point.Enumerable.Actual(
			new Vertex::Member.Translation.Multiple(vertices))
	)
	{
	}
}