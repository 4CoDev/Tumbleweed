using SCG = System.Collections.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Mesh.Concave;

public interface Any
{
	SCG::IEnumerable<Polygon.Any> Polygons { get; }
}