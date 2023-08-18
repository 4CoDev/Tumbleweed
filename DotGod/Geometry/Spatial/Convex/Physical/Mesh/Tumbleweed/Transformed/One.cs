using Enumerable = Tumbleweed.Geometry.Spatial.Convex.Mesh.Member.Vertex.Enumerable;
using Mesh = Tumbleweed.Geometry.Spatial.Convex.Mesh;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using Vertex = DotGod.Geometry.Spatial.Convex.Physical.Vertex;

namespace DotGod.Geometry.Spatial.Convex.Physical.Mesh.Tumbleweed.Transformed;

public sealed class One : Mesh::Envelope
{
	public One
	(
		Mesh::Any mesh,
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
		Mesh::Any mesh,
		Scalar::Any<Godot::Transform3D> transform
	) : base
	(
		new Mesh::With.Vertex.Enumerable.One(
			new Vertex::Transformed.Enumerable(
				new Enumerable(mesh),
				transform))
	)
	{
	}
}