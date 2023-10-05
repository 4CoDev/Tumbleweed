using Tumbleweed.Scalar.Immutable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Surface.With.Members;

public sealed class One : Any
{
	public One
	(
		IEnumerable<Graphical.Polygon.Any> polygons,
		Any<Godot.Material> material
	)
	{
		Polygons = polygons;
		Material = material;
	}
	
	public IEnumerable<Graphical.Polygon.Any> Polygons { get; }
	
	public Any<Godot.Material> Material { get; }
}