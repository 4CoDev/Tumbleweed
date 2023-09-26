using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.With.Translation;

public sealed class One : Any
{
	public One(Any<Mathematics.Number.Real.Any> translation) =>
		Translation = translation;

	public Any<Mathematics.Number.Real.Any> Translation { get; }
}