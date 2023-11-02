using DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Tumbleweed.From.Godot;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace DotGod.Node.Node3D.CollisionShape3D.Shape.Specific.Origin.Mesh.Convex.As.Convex.Untransformed.Tumbleweed;

public sealed class Actual : Envelope
{
	public Actual(global::Godot.CollisionShape3D collider) : this
	(
		new One<global::Godot.CollisionShape3D>(collider)
	)
	{
	}
	
	public Actual(Any<global::Godot.CollisionShape3D> collider) : base
	(
		new One(
			new Abstract.Godot.Actual(collider))
	)
	{
	}
}