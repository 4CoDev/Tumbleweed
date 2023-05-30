using DotGod.Spatial.Graphical.Concave.Geometry.Surface;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

public sealed class MeshWithSurfaces : IMesh
{
	public MeshWithSurfaces(IEnumerable<ISurface> surfaces) =>
		Surfaces = surfaces;
	
	public IEnumerable<ISurface> Surfaces { get; }
}