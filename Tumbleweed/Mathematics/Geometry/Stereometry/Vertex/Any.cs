using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Vertex;

public interface Any
{
	Any<Real::Any> Translation { get; }
}