using DotGod.Geometry.Spatial.Graphical.Surface;

namespace DotGod.Geometry.Spatial.Graphical._Mesh;

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