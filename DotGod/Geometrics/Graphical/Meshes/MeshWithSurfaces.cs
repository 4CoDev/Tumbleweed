using DotGod.Geometrics.Graphical.Surfaces;

namespace DotGod.Geometrics.Graphical.Meshes;

public sealed class MeshWithSurfaces : IMesh
{
	public MeshWithSurfaces(IEnumerable<ISurface> surfaces) =>
		Surfaces = surfaces;
	
	public IEnumerable<ISurface> Surfaces { get; }
}