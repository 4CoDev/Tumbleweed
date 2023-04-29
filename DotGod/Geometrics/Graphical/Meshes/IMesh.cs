using DotGod.Geometrics.Graphical.Surfaces;

namespace DotGod.Geometrics.Graphical.Meshes;

public interface IMesh
{
	IEnumerable<ISurface> Surfaces { get; }
}