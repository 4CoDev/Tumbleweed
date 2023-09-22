using Point = Tumbleweed.Point;
using Real = Tumbleweed.Number.Real;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex;

public abstract class Envelope : Any
{
	protected Envelope(Any vertex) =>
		this.vertex = vertex;

	public Tumbleweed.Point.Spatial.Generic.Any<Real::Any> Translation =>
		vertex.Translation;

	public Tumbleweed.Point.Spatial.Generic.Any<Real::Any> Normal =>
		vertex.Normal;

	public Immutable::Any<Godot::Color> Color =>
		vertex.Color;

	public Point::Planar.Any<Real::Any> UV =>
		vertex.UV;

	private readonly Any vertex;
}