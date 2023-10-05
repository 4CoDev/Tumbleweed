using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Real = Tumbleweed.Mathematics.Number.Real;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex;

public interface Any
{
	Any<Tumbleweed.Mathematics.Number.Real.Any> Translation { get; }

	Any<Tumbleweed.Mathematics.Number.Real.Any> Normal { get; }

	Immutable::Any<Godot::Color> Color { get; }

	Tumbleweed.Mathematics.Vector.Planar.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> UV { get; }
}