using SCG = System.Collections.Generic;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Polygon;

public interface Any
{
	SCG::IEnumerable<Graphical.Vertex.Any> Vertices { get; }
}