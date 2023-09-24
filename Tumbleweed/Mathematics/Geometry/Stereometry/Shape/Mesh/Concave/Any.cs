using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Concave;

public interface Any
{
	SCG::IEnumerable<Polygon.Any> Polygons { get; }
}