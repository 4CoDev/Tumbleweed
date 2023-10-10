using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using Cuboid = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Instance.Cuboid;

namespace DotGod.Node.Node3D.CollisionShape3D.Shape.Specific.Origin.Parametric.Cuboid.Mesh.Tumbleweed;

public sealed class Actual : Envelope
{
	public Actual
	(
		Godot::CollisionShape3D collider
	) : this
	(
		new Scalar::With.Value
			<Godot::CollisionShape3D>
			(collider)
	)
	{
	}
	
	public Actual
	(
		Scalar::Any<Godot::CollisionShape3D> collider
	) : base
	(
		new Cuboid::Mesh.With.Origin.Center.Size.Definition.Tumbleweed(
			new Size.Tumbleweed(collider))
	)
	{
	}
}