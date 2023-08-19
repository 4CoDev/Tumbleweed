using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot.With.Vertex.
	Translation.Vector.Array.System;

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