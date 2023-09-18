using SCG = System.Collections.Generic;

namespace DotGod.Geometry.Spatial.Graphical.Polygon;

public interface Any
{
	SCG::IEnumerable<Graphical.Vertex.Any> Vertices { get; }
}