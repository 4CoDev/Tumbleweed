using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.Transformed;

public sealed class One : Property::Envelope<Godot::ConvexPolygonShape3D>
{
	public One
	(
		Godot::ConvexPolygonShape3D mesh,
		Godot::Transform3D transform
	) : this
	(
		mesh,
		new Property::With.Value.One<Godot::Transform3D>(transform)
	)
	{
	}
	
	public One
	(
		Godot::ConvexPolygonShape3D mesh,
		Property::Any<Godot::Transform3D> transform
	) : base
	(
		new From.Tumbleweed.One(
			new Tumbleweed.Transformed.One(
				new Shape.Mesh.Convex.Tumbleweed.From.Godot.One(mesh),
				transform))
	)
	{
	}
}