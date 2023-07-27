using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Convex.Mesh;

public interface Any
{
	SCG::IEnumerable<Vertex::Any> Vertices { get; }
}