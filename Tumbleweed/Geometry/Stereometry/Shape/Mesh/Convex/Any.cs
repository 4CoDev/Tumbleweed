using SCG = System.Collections.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex;

public interface Any
{
	SCG::IEnumerable<Vertex.Any> Vertices { get; }
}