using Vertex = DotGod.Geometry.Spatial.Concave.Graphical.Vertex;
using Scalar = Tumbleweed.Scalar.Immutable;
using Point = Tumbleweed.Point;
using Real = Tumbleweed.Number.Real;
using Godot = Godot;

// ReSharper disable once CheckNamespace
namespace DotGod.Geometry.Spatial.Concave.Graphical.Vertex.Scalar;

public sealed class Value : Vertex::Any
{
	public Value(Scalar::Any<Vertex::Any> vertex) =>
		this.vertex = vertex;
	
	public Point::Spatial.Any<Real::Any> Translation =>
		vertex.Value.Translation;

	public Point::Spatial.Any<Real::Any> Normal =>
		vertex.Value.Normal;

	public Scalar::Any<Godot::Color> Color =>
		vertex.Value.Color;

	public Point::Planar.Any<Real::Any> UV =>
		vertex.Value.UV;

	private readonly Scalar::Any<Vertex::Any> vertex;
}