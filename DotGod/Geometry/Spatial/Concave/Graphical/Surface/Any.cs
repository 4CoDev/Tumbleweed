using DotGod.Geometry.Spatial.Concave.Graphical.Polygon;
using Godot;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Surface;

public interface Any
{
	IEnumerable<Graphical.Polygon.Any> Polygons { get; }
	
	Any<Godot.Material> Material { get; }
}
