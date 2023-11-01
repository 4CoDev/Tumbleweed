using Godot;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Polygon.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any polygon,
		Any<Transform3D> transform
	) : base
	(
		new With.Vertex.Enumerable.One(
			new Graphical.Vertex.Transformed.Enumerable(
				new Result<Graphical.Vertex.Any>(() => polygon.Vertices),
				transform))
	)
	{
	}
}