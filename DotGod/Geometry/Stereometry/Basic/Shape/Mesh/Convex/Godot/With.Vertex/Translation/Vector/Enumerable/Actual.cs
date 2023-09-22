using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using SCG = System.Collections.Generic;
using Array = Tumbleweed.Array.Dimension.Linear.System;

namespace DotGod.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Translation.Vector.Enumerable;

public sealed class Actual : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public Actual
	(
		SCG::IEnumerable<Godot::Vector3> translations
	) : base
	(
		new Array.System.Actual(
			new Array::From.Enumerable.One
				<Godot::Vector3>
				(translations))
	)
	{
	}
}