using DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Tumbleweed.Transformed;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex;
using Godot = Godot;
using Property = Tumbleweed.Property.Output;

namespace DotGod.Node.Node3D.CollisionShape3D.Shape.Specific.Origin.Mesh.Convex.As.Convex.Transformed.Tumbleweed;

public sealed class Actual : Envelope
{
	public Actual(Godot::CollisionShape3D collider) : this
	(
		new Property::With.Value.One<Godot::CollisionShape3D>(collider)
	)
	{
	}
	
	public Actual(Property::Any<Godot::CollisionShape3D> collider) : base
	(
		new One(
			new Untransformed.Tumbleweed.Actual(collider),
			new Node.Node3D.Member.Transform.One(collider))
	)
	{
	}
}