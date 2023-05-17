using Tumbleweed.Geometry.Spatial.Vertices;

namespace Tumbleweed.Geometry.Spatial.Convex;

public interface IMesh
{
	IEnumerable<IVertex> Vertices { get; }
}