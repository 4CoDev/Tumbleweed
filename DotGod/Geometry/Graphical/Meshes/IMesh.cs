using DotGod.Geometry.Graphical.Surfaces;

namespace DotGod.Geometry.Graphical.Meshes;

public interface IMesh
{
	IEnumerable<ISurface> Surfaces { get; }
}