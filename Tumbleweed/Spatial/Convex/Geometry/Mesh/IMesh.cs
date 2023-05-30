using Tumbleweed.Spatial.Geometry.Vertex;

namespace Tumbleweed.Spatial.Convex.Geometry.Mesh;

public interface IMesh
{
	IEnumerable<IVertex> Vertices { get; }
}