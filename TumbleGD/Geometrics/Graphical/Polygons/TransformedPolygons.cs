using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Polygons;

public sealed class TransformedPolygons
	: EnumerableEnvelope<IEnumerable<IVertex>>
{
	public TransformedPolygons
	(
		IEnumerable<IEnumerable<IVertex>> polygons,
		IScalar<Transform3D> transform
	) : base
	(
		new SelectedByExpression<IEnumerable<IVertex>>(
			polygons,
			polygon => new TransformedVertices(polygon, transform))
	)
	{
	}
}