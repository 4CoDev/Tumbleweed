using Vertex = DotGod.Geometry.Spatial.Concave.Graphical.Vertex;
using Point = Tumbleweed.Point;
using Real = Tumbleweed.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

// ReSharper disable once CheckNamespace
namespace DotGod.Geometry.Spatial.Concave.Graphical.Vertex.With;

public sealed class Members : Vertex::Any
{
	public Members
	(
		Point::Spatial.Any<Real::Any> translation,
		Point::Spatial.Any<Real::Any> normal,
		Scalar::Any<Godot::Color> color,
		Point::Planar.Any<Real::Any> uv
	)
	{
		Translation = translation;
		Normal = normal;
		Color = color;
		UV = uv;
	}
	
	public Point::Spatial.Any<Real::Any> Translation { get; }
	
	public Point::Spatial.Any<Real::Any> Normal { get; }
	
	public Scalar::Any<Godot::Color> Color { get; }
	
	public Point::Planar.Any<Real::Any> UV { get; }
}