using Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using CuboidMesh = Tumbleweed.Geometry.Stereometry.Shape.Parametric.Cuboid.Mesh;

namespace DotGod.Physics.Collider.Spatial.Geometry.Shape.Parametric.Cuboid.Mesh.Tumbleweed;

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
		new global::Tumbleweed.Geometry.Stereometry.Shape.Parametric.Cuboid.Mesh.With.Origin.Center.Size.Definition.Tumbleweed(
			new Size.Tumbleweed(collider))
	)
	{
	}
}