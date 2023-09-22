using SCG = System.Collections.Generic;

namespace Tumbleweed.Geometry.Stereometry.Polygon;

public interface Any
{
	SCG::IEnumerable<Vertex.Any> Vertices { get; }
}