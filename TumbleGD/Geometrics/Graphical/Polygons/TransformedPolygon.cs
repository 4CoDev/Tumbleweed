using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Polygons;

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