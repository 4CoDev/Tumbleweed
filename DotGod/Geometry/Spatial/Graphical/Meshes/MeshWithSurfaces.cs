using DotGod.Geometry.Spatial.Graphical.Surfaces;

namespace DotGod.Geometry.Spatial.Graphical.Meshes;

public sealed class MeshWithSurfaces : IMesh
{
	public MeshWithSurfaces(IEnumerable<ISurface> surfaces) =>
		Surfaces = surfaces;
	
	public IEnumerable<ISurface> Surfaces { get; }
}