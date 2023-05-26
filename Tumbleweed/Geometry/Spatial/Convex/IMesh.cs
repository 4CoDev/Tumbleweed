using Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Convex;

public interface IMesh
{
	IEnumerable<IVertex> Vertices { get; }
}