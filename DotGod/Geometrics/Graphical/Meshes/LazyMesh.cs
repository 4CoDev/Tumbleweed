using DotGod.Geometrics.Graphical.Surfaces;

namespace DotGod.Geometrics.Graphical.Meshes;

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