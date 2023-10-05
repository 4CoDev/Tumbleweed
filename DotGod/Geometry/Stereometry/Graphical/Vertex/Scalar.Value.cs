using DotGod.Geometry.Stereometry.Graphical.Vertex;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Vertex = DotGod.Geometry.Stereometry.Concave.Graphical.Vertex;
using Scalar = Tumbleweed.Scalar.Immutable;
using Real = Tumbleweed.Mathematics.Number.Real;
using Godot = Godot;

// ReSharper disable once CheckNamespace
namespace DotGod.Geometry.Stereometry.Concave.Graphical.Vertex.Scalar;

public sealed class Value : Any
{
	public Value(Scalar::Any<Any> vertex) =>
		this.vertex = vertex;
	
	public Any<Tumbleweed.Mathematics.Number.Real.Any> Translation =>
		vertex.Value.Translation;

	public Any<Tumbleweed.Mathematics.Number.Real.Any> Normal =>
		vertex.Value.Normal;

	public Scalar::Any<Godot::Color> Color =>
		vertex.Value.Color;

	public Tumbleweed.Mathematics.Vector.Planar.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> UV =>
		vertex.Value.UV;

	private readonly Scalar::Any<Any> vertex;
}