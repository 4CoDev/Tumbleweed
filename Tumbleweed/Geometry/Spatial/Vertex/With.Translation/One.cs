using Tumbleweed.Point.Spatial.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Spatial.Vertex.With.Translation;

public sealed class One : Vertex::Any
{
	public One(Any<Real::Any> translation) =>
		Translation = translation;

	public Any<Real::Any> Translation { get; }
}