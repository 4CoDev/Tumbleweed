using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

public sealed class TransformedPolygons
	: Tumbleweed.Enumerable.Envelope<IPolygon>
{
	public TransformedPolygons
	(
		IEnumerable<IPolygon> polygons,
		Any<Transform3D> transform
	) : base
	(
		new Selected<IPolygon>(
			polygons,
			polygon => new TransformedPolygon(polygon, transform))
	)
	{
	}
}