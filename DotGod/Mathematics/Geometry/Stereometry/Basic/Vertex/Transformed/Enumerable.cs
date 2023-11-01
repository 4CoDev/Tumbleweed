using Tumbleweed.Mathematics.Geometry.Stereometry.Vertex;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using Godot = Godot;
using Property = Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Vertex.Transformed;

public sealed class Enumerable : Enumerable::Envelope<Any>
{
	public Enumerable
	(
		SCG::IEnumerable<Any> vertices,
		Godot::Transform3D transform
	) : this
	(
		vertices,
		new Property::With.Value<Godot::Transform3D>(transform)
	)
	{
	}
	
	public Enumerable
	(
		SCG::IEnumerable<Any> vertices,
		Property::Any<Godot::Transform3D> transform
	) : base
	(
		new Enumerable::Selected<Any>(
			vertices,
			vertex => new One(vertex, transform))
	)
	{
	}
}