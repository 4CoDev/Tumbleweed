using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Translation.Vector.Array.System;

public sealed class Actual : Property::Envelope<Godot::ConvexPolygonShape3D>
{
	public Actual
	(
		params Godot::Vector3[] translations
	) : this
	(
		new Property::With.Value.One<Godot::Vector3[]>(translations)
	)
	{
	}
	
	public Actual
	(
		Property::Any<Godot::Vector3[]> translations
	) : base
	(
		new Property::Function.Result.Actual<Godot::ConvexPolygonShape3D>(
			() => new Godot::ConvexPolygonShape3D
				{Points = translations.Value})
	)
	{
	}
}