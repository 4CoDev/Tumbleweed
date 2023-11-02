using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex;
using Enumerable = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Member.Vertex.Whole.Enumerable;
using Godot = Godot;
using Property = Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Tumbleweed.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any mesh,
		Godot::Transform3D transform
	) : this
	(
		mesh,
		new Property::With.Value.One<Godot::Transform3D>(transform)
	)
	{
	}
	
	public One
	(
		Any mesh,
		Property::Any<Godot::Transform3D> transform
	) : base
	(
		new global::Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.With.Vertex.Whole.Enumerable.One(
			new Vertex.Transformed.Enumerable(
				new Enumerable(mesh),
				transform))
	)
	{
	}
}