using DotGod.Geometry.Graphical.Polygons;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Surfaces;

public interface ISurface
{
	IEnumerable<IPolygon> Polygons { get; }
	
	IScalar<Material> Material { get; }
}
