using SCG = System.Collections.Generic;
using Vertex = DotGod.Geometry.Spatial.Concave.Graphical.Vertex;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Polygon;

public interface Any
{
	SCG::IEnumerable<Vertex::Any> Vertices { get; }
}