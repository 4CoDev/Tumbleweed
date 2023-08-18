using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using SCG = System.Collections.Generic;
using Mesh = DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot;
using Array = Tumbleweed.Array.Dimension.Linear.System;

namespace DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot.With.Vertex.
	Translation.Vector.Enumerable;

public sealed class Actual : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public Actual
	(
		SCG::IEnumerable<Godot::Vector3> translations
	) : base
	(
		new Mesh::With.Vertex.Translation.Vector.Array.System.Actual(
			new Array::From.Enumerable.One
				<Godot::Vector3>
				(translations))
	)
	{
	}
}