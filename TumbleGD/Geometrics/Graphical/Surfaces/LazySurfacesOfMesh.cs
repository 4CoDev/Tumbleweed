using TumbleGD.Geometrics.Graphical.Meshes;
using Tumbleweed.Enumerables;

namespace TumbleGD.Geometrics.Graphical.Surfaces;

public sealed class LazySurfacesOfMesh : EnumerableEnvelope<ISurface>
{
	public LazySurfacesOfMesh(IMesh mesh) : base
	(
		new LazySelectedByExpression<ISurface>(
			new SurfacesOfMesh(mesh),
			surface => new LazySurface(surface))
	)
	{
	}
}