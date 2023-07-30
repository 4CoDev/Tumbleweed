using DotGod.Spatial.Graphical.Concave.Geometry.Polygon;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

public interface ISurface
{
	IEnumerable<IPolygon> Polygons { get; }
	
	Any<Material> Material { get; }
}
