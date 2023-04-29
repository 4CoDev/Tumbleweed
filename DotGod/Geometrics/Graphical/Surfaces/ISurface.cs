using DotGod.Geometrics.Graphical.Polygons;
using Godot;
using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Surfaces;

public interface ISurface
{
	IEnumerable<IPolygon> Polygons { get; }
	
	IScalar<Material> Material { get; }
}
