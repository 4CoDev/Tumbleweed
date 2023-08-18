using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Mesh = DotGod.Geometry.Spatial.Convex.Physical.Mesh;

namespace DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot.Transformed;

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
		new Mesh::Godot.From.Tumbleweed.One(
			new Mesh::Tumbleweed.Transformed.One(
				new Mesh::Tumbleweed.From.Godot.One(mesh),
				transform))
	)
	{
	}
}