using Tumbleweed.Point.Spatial;

namespace Tumbleweed.Geometry.Spatial.Aabb;

public interface Any
{
	Any<Tumbleweed.Number.Real.Any> A { get; }
	
	Any<Tumbleweed.Number.Real.Any> B { get; }
}