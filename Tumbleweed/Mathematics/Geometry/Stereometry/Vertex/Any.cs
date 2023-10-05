using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Vertex;

public interface Any
{
	Any<Real::Any> Translation { get; }
}