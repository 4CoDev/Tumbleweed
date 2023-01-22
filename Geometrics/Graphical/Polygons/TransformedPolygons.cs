using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.Graphical.Polygons;

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