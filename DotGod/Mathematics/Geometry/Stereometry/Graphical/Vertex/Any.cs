using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex;

public interface Any
{
	Tumbleweed.Mathematics.Vector.Spatial.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> Translation { get; }

	Tumbleweed.Mathematics.Vector.Spatial.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> Normal { get; }

	Property::Any<Godot::Color> Color { get; }

	Tumbleweed.Mathematics.Vector.Planar.Generic.Any<Tumbleweed.Mathematics.Number.Real.Any> UV { get; }
}