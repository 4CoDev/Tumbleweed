using Godot;
using Tumbleweed.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.Graphical.Surfaces;

public interface ISurface
{
	IEnumerable<IEnumerable<IVertex>> Polygons { get; }
	
	IScalar<Material> Material { get; }
}
