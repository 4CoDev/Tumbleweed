using DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.From.Tumbleweed;
using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Node.Node3D.CollisionShape3D.Shape.Specific.Origin.Mesh.Convex.As.Convex.Transformed.Godot;

public sealed class Actual : Property::Envelope<Godot::ConvexPolygonShape3D>
{
	public Actual
	(
		Godot::CollisionShape3D collider
	) : this
	(
		new Property::With.Value
			<Godot::CollisionShape3D>
			(collider)
	)
	{
	}
	
	public Actual
	(
		Property::Any<Godot::CollisionShape3D> collider
	) : base
	(
		new One(
			new Untransformed.Tumbleweed.Actual(collider))
	)
	{
	}
}