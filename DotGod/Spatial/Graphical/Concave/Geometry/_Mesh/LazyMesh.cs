using DotGod.Spatial.Graphical.Concave.Geometry.Surface;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

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