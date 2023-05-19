using DotGod.Geometry.Spatial.Graphical.Meshes;
using Tumbleweed.Enumerables;

namespace DotGod.Geometry.Spatial.Graphical.Surfaces;

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