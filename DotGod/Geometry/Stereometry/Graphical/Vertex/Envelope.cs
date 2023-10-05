using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Real = Tumbleweed.Mathematics.Number.Real;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex;

public abstract class Envelope : Any
{
	protected Envelope(Any vertex) =>
		this.vertex = vertex;

	public Any<Tumbleweed.Mathematics.Number.Real.Any> Translation =>
		vertex.Translation;

	public Any<Tumbleweed.Mathematics.Number.Real.Any> Normal =>
		vertex.Normal;

	public Immutable::Any<Godot::Color> Color =>
		vertex.Color;

	public Tumbleweed.Mathematics.Vector.Planar.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> UV =>
		vertex.UV;

	private readonly Any vertex;
}