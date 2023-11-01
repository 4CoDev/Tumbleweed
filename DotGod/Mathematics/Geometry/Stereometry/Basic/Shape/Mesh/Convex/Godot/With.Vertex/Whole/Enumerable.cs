using DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Translation.Point.Enumerable;
using Tumbleweed.Mathematics.Geometry.Stereometry.Vertex;
using Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Member.Translation;
using Property = Tumbleweed.Property.Output;
using Godot = Godot;
using SCG = System.Collections.Generic;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Whole;

public sealed class Enumerable : Property::Envelope<Godot::ConvexPolygonShape3D>
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