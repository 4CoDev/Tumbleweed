using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex;

public interface Any
{
	SCG::IEnumerable<Vertex.Any> Vertices { get; }
}