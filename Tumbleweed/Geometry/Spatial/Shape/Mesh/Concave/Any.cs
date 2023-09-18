using SCG = System.Collections.Generic;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Concave;

public interface Any
{
	SCG::IEnumerable<Polygon.Any> Polygons { get; }
}