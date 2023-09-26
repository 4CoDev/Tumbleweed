using DotGod.Geometry.Stereometry.Graphical.Vertex;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Vertex = DotGod.Geometry.Stereometry.Concave.Graphical.Vertex;
using Point = Tumbleweed.Point;
using Real = Tumbleweed.Mathematics.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

// ReSharper disable once CheckNamespace
namespace DotGod.Geometry.Stereometry.Concave.Graphical.Vertex.With;

public sealed class Members : Any
{
	public Members
	(
		Any<Tumbleweed.Mathematics.Number.Real.Any> translation,
		Any<Tumbleweed.Mathematics.Number.Real.Any> normal,
		Scalar::Any<Godot::Color> color, Tumbleweed.Mathematics.Geometry.Planimetry.Point.Any<Tumbleweed.Mathematics.Number.Real.Any> uv
	)
	{
		Translation = translation;
		Normal = normal;
		Color = color;
		UV = uv;
	}
	
	public Any<Tumbleweed.Mathematics.Number.Real.Any> Translation { get; }
	
	public Any<Tumbleweed.Mathematics.Number.Real.Any> Normal { get; }
	
	public Scalar::Any<Godot::Color> Color { get; }
	
	public Tumbleweed.Mathematics.Geometry.Planimetry.Point.Any<Tumbleweed.Mathematics.Number.Real.Any> UV { get; }
}