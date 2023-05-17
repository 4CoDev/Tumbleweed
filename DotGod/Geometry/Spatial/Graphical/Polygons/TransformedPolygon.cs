using DotGod.Geometry.Spatial.Graphical.Vertices;
using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Polygons;

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