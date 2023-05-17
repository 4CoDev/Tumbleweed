using DotGod.Geometry.Spatial.Graphical.Polygons;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Surfaces;

public interface ISurface
{
	IEnumerable<IPolygon> Polygons { get; }
	
	IScalar<Material> Material { get; }
}
