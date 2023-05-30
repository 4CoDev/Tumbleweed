using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

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