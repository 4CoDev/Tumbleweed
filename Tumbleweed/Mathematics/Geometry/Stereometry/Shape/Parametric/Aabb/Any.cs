using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

public interface Any
{
	Any<Mathematics.Number.Real.Any> A { get; }
	
	Any<Mathematics.Number.Real.Any> B { get; }
}