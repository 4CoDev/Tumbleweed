using Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex;
using Enumerable = Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.Member.Vertex.Whole.Enumerable;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Basic.Shape.Mesh.Convex.Tumbleweed.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any mesh,
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
		Any mesh,
		Scalar::Any<Godot::Transform3D> transform
	) : base
	(
		new global::Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.With.Vertex.Whole.Enumerable.One(
			new Vertex.Transformed.Enumerable(
				new Enumerable(mesh),
				transform))
	)
	{
	}
}