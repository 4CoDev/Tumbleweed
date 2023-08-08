using Point = Tumbleweed.Point;
using Real = Tumbleweed.Number.Real;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Vertex;

public interface Any
{
	Point::Spatial.Any<Real::Any> Translation { get; }

	Point::Spatial.Any<Real::Any> Normal { get; }

	Immutable::Any<Godot::Color> Color { get; }

	Point::Planar.Any<Real::Any> UV { get; }
}