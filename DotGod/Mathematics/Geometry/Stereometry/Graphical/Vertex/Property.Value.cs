using DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Vertex = DotGod.Geometry.Stereometry.Concave.Graphical.Vertex;
using Property = Tumbleweed.Property.Output;
using Real = Tumbleweed.Mathematics.Number.Real;
using Godot = Godot;

// ReSharper disable once CheckNamespace
namespace DotGod.Geometry.Stereometry.Concave.Graphical.Vertex.Property;

public sealed class Value : Any
{
	public Value(Property::Any<Any> vertex) =>
		this.vertex = vertex;
	
	public Any<Tumbleweed.Mathematics.Number.Real.Any> Translation =>
		vertex.Value.Translation;

	public Any<Tumbleweed.Mathematics.Number.Real.Any> Normal =>
		vertex.Value.Normal;

	public Property::Any<Godot::Color> Color =>
		vertex.Value.Color;

	public Tumbleweed.Mathematics.Vector.Planar.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> UV =>
		vertex.Value.UV;

	private readonly Property::Any<Any> vertex;
}