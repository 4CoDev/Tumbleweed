using DotGod.Geometry.Graphical.Surfaces;

namespace DotGod.Geometry.Graphical.Meshes;

public sealed class MeshWithSurfaces : IMesh
{
	public MeshWithSurfaces(IEnumerable<ISurface> surfaces) =>
		Surfaces = surfaces;
	
	public IEnumerable<ISurface> Surfaces { get; }
}