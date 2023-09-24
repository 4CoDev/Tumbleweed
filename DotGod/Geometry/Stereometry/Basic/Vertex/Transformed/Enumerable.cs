using Tumbleweed.Mathematics.Geometry.Stereometry.Vertex;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Stereometry.Basic.Vertex.Transformed;

public sealed class Enumerable : Enumerable::Envelope<Any>
{
	public Enumerable
	(
		SCG::IEnumerable<Any> vertices,
		Godot::Transform3D transform
	) : this
	(
		vertices,
		new Scalar::With.Value<Godot::Transform3D>(transform)
	)
	{
	}
	
	public Enumerable
	(
		SCG::IEnumerable<Any> vertices,
		Scalar::Any<Godot::Transform3D> transform
	) : base
	(
		new Enumerable::Selected<Any>(
			vertices,
			vertex => new One(vertex, transform))
	)
	{
	}
}