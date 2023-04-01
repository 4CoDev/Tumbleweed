using TumbleGD.Geometrics.Graphical.Surfaces;

namespace TumbleGD.Geometrics.Graphical.Meshes;

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