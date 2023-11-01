using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Surface;

public interface Any
{
	IEnumerable<Graphical.Polygon.Any> Polygons { get; }
	
	Any<Godot.Material> Material { get; }
}
