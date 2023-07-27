using SCG = System.Collections.Generic;
using Polygon = Tumbleweed.Geometry.Spatial.Concave.Polygon;

namespace Tumbleweed.Geometry.Spatial.Concave.Mesh;

public interface Any
{
	SCG::IEnumerable<Polygon::Any> Polygons { get; }
}