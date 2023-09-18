using Enumerable = Tumbleweed.Enumerable;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using SCG = System.Collections.Generic;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Basic.Vertex.Transformed;

public sealed class Enumerable : Enumerable::Envelope<Vertex::Any>
{
	public Enumerable
	(
		SCG::IEnumerable<Vertex::Any> vertices,
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
		SCG::IEnumerable<Vertex::Any> vertices,
		Scalar::Any<Godot::Transform3D> transform
	) : base
	(
		new Enumerable::Selected<Vertex::Any>(
			vertices,
			vertex => new One(vertex, transform))
	)
	{
	}
}