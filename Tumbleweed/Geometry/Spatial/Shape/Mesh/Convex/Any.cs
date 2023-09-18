using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex;

public interface Any
{
	SCG::IEnumerable<Vertex::Any> Vertices { get; }
}