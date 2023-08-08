using Godot;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar.Immutable;
using Vertex = DotGod.Geometry.Spatial.Concave.Graphical.Vertex;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any polygon,
		Any<Transform3D> transform
	) : base
	(
		new With.Vertex.Enumerable.One(
			new Vertex::Transformed.Enumerable(
				new Result<Vertex::Any>(() => polygon.Vertices),
				transform))
	)
	{
	}
}