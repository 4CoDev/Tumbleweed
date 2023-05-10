using DotGod.Geometry.Graphical.Surfaces;

namespace DotGod.Geometry.Graphical.Meshes;

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