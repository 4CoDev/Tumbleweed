using Point = Tumbleweed.Point;
using Real = Tumbleweed.Number.Real;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex;

public interface Any
{
	Tumbleweed.Point.Spatial.Generic.Any<Real::Any> Translation { get; }

	Tumbleweed.Point.Spatial.Generic.Any<Real::Any> Normal { get; }

	Immutable::Any<Godot::Color> Color { get; }

	Point::Planar.Any<Real::Any> UV { get; }
}