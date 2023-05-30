using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

public sealed class TransformedPolygon : PolygonEnvelope
{
	public TransformedPolygon
	(
		IPolygon polygon,
		IScalar<Transform3D> transform
	) : base
	(
		new PolygonWithVertices(
			new TransformedVertices(
				new EnumerableOfFunction<IVertex>(() => polygon.Vertices),
				transform))
	)
	{
	}
}