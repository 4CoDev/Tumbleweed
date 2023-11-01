using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex;

public abstract class Envelope : Any
{
	protected Envelope(Any vertex) =>
		this.vertex = vertex;

	public Tumbleweed.Mathematics.Vector.Spatial.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> Translation =>
		vertex.Translation;

	public Tumbleweed.Mathematics.Vector.Spatial.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> Normal =>
		vertex.Normal;

	public Property::Any<Godot::Color> Color =>
		vertex.Color;

	public Tumbleweed.Mathematics.Vector.Planar.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> UV =>
		vertex.UV;

	private readonly Any vertex;
}