using Tumbleweed.Point.Spatial.Generic;
using Point = Tumbleweed.Point;
using Real = Tumbleweed.Number.Real;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Spatial.Graphical.Vertex;

public interface Any
{
	Any<Real::Any> Translation { get; }

	Any<Real::Any> Normal { get; }

	Immutable::Any<Godot::Color> Color { get; }

	Point::Planar.Any<Real::Any> UV { get; }
}