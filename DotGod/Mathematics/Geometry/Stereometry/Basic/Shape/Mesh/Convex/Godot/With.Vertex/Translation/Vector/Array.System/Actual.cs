using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Translation.Vector.Array.System;

public sealed class Actual : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public Actual
	(
		params Godot::Vector3[] translations
	) : this
	(
		new Scalar::With.Value<Godot::Vector3[]>(translations)
	)
	{
	}
	
	public Actual
	(
		Scalar::Any<Godot::Vector3[]> translations
	) : base
	(
		new Scalar::Function.Result.Actual<Godot::ConvexPolygonShape3D>(
			() => new Godot::ConvexPolygonShape3D
				{Points = translations.Value})
	)
	{
	}
}