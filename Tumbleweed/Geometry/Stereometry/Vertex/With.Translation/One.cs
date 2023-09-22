using Tumbleweed.Point.Spatial.Generic;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Vertex.With.Translation;

public sealed class One : Any
{
	public One(Any<Real::Any> translation) =>
		Translation = translation;

	public Any<Real::Any> Translation { get; }
}