using Tumbleweed.Geometry.Spatial.Polygons;

namespace Tumbleweed.Geometry.Spatial.Shapes;

public sealed class ShapeWithPolygons : IShape
{
	public ShapeWithPolygons(IEnumerable<IPolygon> polygons) =>
		Polygons = polygons;

	public IEnumerable<IPolygon> Polygons { get; }
}