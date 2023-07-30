using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public sealed class VertexWithValues : IVertex
{
	public VertexWithValues
	(Tumbleweed.Point.Spatial.Any<Any> translation, Tumbleweed.Point.Spatial.Any<Any> normal, Tumbleweed.Scalar.Immutable.Any<Color> color, Tumbleweed.Point.Planar.Any<Any> uv
	)
	{
		Translation = translation;
		Normal = normal;
		Color = color;
		UV = uv;
	}
	
	public Tumbleweed.Point.Spatial.Any<Any> Translation { get; }
	
	public Tumbleweed.Point.Spatial.Any<Any> Normal { get; }
	
	public Tumbleweed.Scalar.Immutable.Any<Color> Color { get; }
	
	public Tumbleweed.Point.Planar.Any<Any> UV { get; }
}