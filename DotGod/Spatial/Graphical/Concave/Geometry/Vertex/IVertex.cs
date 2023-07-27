using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public interface IVertex
{
	Tumbleweed.Point.Spatial.Any<Any> Translation { get; }

	Tumbleweed.Point.Spatial.Any<Any> Normal { get; }

	Tumbleweed.Scalar.Any<Color> Color { get; }

	Tumbleweed.Point.Planar.Any<Any> UV { get; }
}