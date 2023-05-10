using DotGod.Geometry.Graphical.Vertices;
using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Polygons;

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