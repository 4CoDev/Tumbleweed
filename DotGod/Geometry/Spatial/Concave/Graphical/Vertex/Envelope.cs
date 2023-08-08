using Vertex = DotGod.Geometry.Spatial.Concave.Graphical.Vertex;
using Point = Tumbleweed.Point;
using Real = Tumbleweed.Number.Real;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Vertex;

public abstract class Envelope : Any
{
	protected Envelope(Vertex::Any vertex) =>
		this.vertex = vertex;

	public Point::Spatial.Any<Real::Any> Translation =>
		vertex.Translation;

	public Point::Spatial.Any<Real::Any> Normal =>
		vertex.Normal;

	public Immutable::Any<Godot::Color> Color =>
		vertex.Color;

	public Point::Planar.Any<Real::Any> UV =>
		vertex.UV;

	private readonly Vertex::Any vertex;
}