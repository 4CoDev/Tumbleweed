using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

public sealed class TransformedPolygon : PolygonEnvelope
{
	public TransformedPolygon
	(
		IPolygon polygon,
		Any<Transform3D> transform
	) : base
	(
		new PolygonWithVertices(
			new TransformedVertices(
				new Result<IVertex>(() => polygon.Vertices),
				transform))
	)
	{
	}
}