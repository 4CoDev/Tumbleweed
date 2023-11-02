using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Aabb;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;
using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Node.Node3D.CollisionShape3D.Shape.Specific.Origin.Mesh.Convex.Aabb.Untransformed;

public sealed class Actual : Envelope
{
	public Actual
	(
		Godot::CollisionShape3D collider
	) : this
	(
		new Property::With.Value.One
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
			new As.Convex.Untransformed.Tumbleweed.Actual(collider))
	)
	{
	}
}