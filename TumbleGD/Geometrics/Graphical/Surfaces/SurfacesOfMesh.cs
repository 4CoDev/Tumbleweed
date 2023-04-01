using TumbleGD.Geometrics.Graphical.Meshes;
using Tumbleweed.Enumerables;

namespace TumbleGD.Geometrics.Graphical.Surfaces;

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