using Tumbleweed.Geometry.Spatial.Polygons;

namespace Tumbleweed.Geometry.Spatial.Shapes;

public interface IShape
{
	IEnumerable<IPolygon> Polygons { get; }
}