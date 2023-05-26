using DotGod.Geometry.Spatial.Graphical.Surface;

namespace DotGod.Geometry.Spatial.Graphical._Mesh;

public sealed class MeshWithSurfaces : IMesh
{
	public MeshWithSurfaces(IEnumerable<ISurface> surfaces) =>
		Surfaces = surfaces;
	
	public IEnumerable<ISurface> Surfaces { get; }
}