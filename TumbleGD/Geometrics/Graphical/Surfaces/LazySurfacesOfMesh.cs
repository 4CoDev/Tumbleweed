using TumbleGD.Geometrics.Graphical.Meshes;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.Lazy;

namespace TumbleGD.Geometrics.Graphical.Surfaces;

public sealed class LazySurfacesOfMesh : EnumerableEnvelope<ISurface>
{
	public LazySurfacesOfMesh(IMesh mesh) : base
	(
		new Tumbleweed.Enumerables.Lazy.SelectedByExpression<ISurface>(
			new SurfacesOfMesh(mesh),
			surface => new LazySurface(surface))
	)
	{
	}
}