using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Graphical.Surface;

public interface Any
{
	IEnumerable<Graphical.Polygon.Any> Polygons { get; }
	
	Any<Godot.Material> Material { get; }
}
