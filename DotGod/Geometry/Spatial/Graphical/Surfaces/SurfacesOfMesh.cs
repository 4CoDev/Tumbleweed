using DotGod.Geometry.Spatial.Graphical.Meshes;
using Tumbleweed.Enumerables;

namespace DotGod.Geometry.Spatial.Graphical.Surfaces;

public sealed class SurfacesOfMesh : EnumerableEnvelope<ISurface>
{
	public SurfacesOfMesh(IMesh mesh) : base
	(
		new EnumerableOfFunction<ISurface>(
			() => mesh.Surfaces)
	)
	{
	}
}