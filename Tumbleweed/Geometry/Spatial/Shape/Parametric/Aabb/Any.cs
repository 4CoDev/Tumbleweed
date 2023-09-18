using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb;

public interface Any
{
	Any<Tumbleweed.Number.Real.Any> A { get; }
	
	Any<Tumbleweed.Number.Real.Any> B { get; }
}