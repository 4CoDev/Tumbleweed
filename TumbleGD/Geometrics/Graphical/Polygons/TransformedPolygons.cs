using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Polygons;

public sealed class TransformedPolygons
	: EnumerableEnvelope<IPolygon>
{
	public TransformedPolygons
	(
		IEnumerable<IPolygon> polygons,
		IScalar<Transform3D> transform
	) : base
	(
		new SelectedByExpression<IPolygon>(
			polygons,
			polygon => new TransformedPolygon(polygon, transform))
	)
	{
	}
}