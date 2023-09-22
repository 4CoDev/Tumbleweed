using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.Transformed;

public sealed class One : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public One
	(
		Godot::ConvexPolygonShape3D mesh,
		Godot::Transform3D transform
	) : this
	(
		mesh,
		new Scalar::With.Value<Godot::Transform3D>(transform)
	)
	{
	}
	
	public One
	(
		Godot::ConvexPolygonShape3D mesh,
		Scalar::Any<Godot::Transform3D> transform
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