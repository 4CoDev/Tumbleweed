using DotGod.Geometry.Spatial.Graphical.Surfaces;

namespace DotGod.Geometry.Spatial.Graphical.Meshes;

public interface IMesh
{
	IEnumerable<ISurface> Surfaces { get; }
}