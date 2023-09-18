using Mesh = Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using CuboidMesh = Tumbleweed.Geometry.Spatial.Shape.Parametric.Cuboid.Mesh;

namespace DotGod.Physics.Collider.Spatial.Geometry.Shape.Parametric.Cuboid.Mesh.Tumbleweed;

public sealed class Actual : Mesh::Envelope
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
		new CuboidMesh::With.Origin.Center.Size.Definition.Tumbleweed(
			new Size.Tumbleweed(collider))
	)
	{
	}
}