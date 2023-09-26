using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Point = Tumbleweed.Point;
using Real = Tumbleweed.Mathematics.Number.Real;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex;

public interface Any
{
	Any<Tumbleweed.Mathematics.Number.Real.Any> Translation { get; }

	Any<Tumbleweed.Mathematics.Number.Real.Any> Normal { get; }

	Immutable::Any<Godot::Color> Color { get; }

	Tumbleweed.Mathematics.Geometry.Planimetry.Point.Any<Tumbleweed.Mathematics.Number.Real.Any> UV { get; }
}