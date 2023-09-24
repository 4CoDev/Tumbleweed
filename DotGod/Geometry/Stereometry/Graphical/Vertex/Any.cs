using Point = Tumbleweed.Point;
using Real = Tumbleweed.Mathematics.Number.Real;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex;

public interface Any
{
	Tumbleweed.Point.Spatial.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> Translation { get; }

	Tumbleweed.Point.Spatial.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> Normal { get; }

	Immutable::Any<Godot::Color> Color { get; }

	Point::Planar.Any<Tumbleweed.Mathematics.Number.Real.Any> UV { get; }
}