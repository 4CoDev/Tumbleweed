using DotGod.Spatial.Graphical.Concave.Geometry.Polygon;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

public interface ISurface
{
	IEnumerable<IPolygon> Polygons { get; }
	
	IScalar<Material> Material { get; }
}
