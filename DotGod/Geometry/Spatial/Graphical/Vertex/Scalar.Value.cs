using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed.Point.Spatial.Generic;
using Vertex = DotGod.Geometry.Spatial.Concave.Graphical.Vertex;
using Scalar = Tumbleweed.Scalar.Immutable;
using Point = Tumbleweed.Point;
using Real = Tumbleweed.Number.Real;
using Godot = Godot;

// ReSharper disable once CheckNamespace
namespace DotGod.Geometry.Spatial.Concave.Graphical.Vertex.Scalar;

public sealed class Value : Any
{
	public Value(Scalar::Any<Any> vertex) =>
		this.vertex = vertex;
	
	public Any<Real::Any> Translation =>
		vertex.Value.Translation;

	public Any<Real::Any> Normal =>
		vertex.Value.Normal;

	public Scalar::Any<Godot::Color> Color =>
		vertex.Value.Color;

	public Point::Planar.Any<Real::Any> UV =>
		vertex.Value.UV;

	private readonly Scalar::Any<Any> vertex;
}