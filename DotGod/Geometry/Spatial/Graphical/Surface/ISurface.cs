using DotGod.Geometry.Spatial.Graphical.Polygon;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface;

public interface ISurface
{
	IEnumerable<IPolygon> Polygons { get; }
	
	IScalar<Material> Material { get; }
}
