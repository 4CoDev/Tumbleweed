using DotGod.Geometry.Spatial.Graphical.Surfaces;

namespace DotGod.Geometry.Spatial.Graphical.Meshes;

public sealed class LazyMesh : MeshEnvelope
{
	public LazyMesh(IMesh mesh) : base
	(
		new MeshWithSurfaces(
			new LazySurfacesOfMesh(mesh))
	)
	{
	}
}