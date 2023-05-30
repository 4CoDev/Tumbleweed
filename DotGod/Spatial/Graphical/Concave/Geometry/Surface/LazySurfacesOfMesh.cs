using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Tumbleweed._Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

public sealed class LazySurfacesOfMesh : EnumerableEnvelope<ISurface>
{
	public LazySurfacesOfMesh(IMesh mesh) : base
	(
		new Tumbleweed._Enumerable.Lazy.SelectedByExpression<ISurface>(
			new SurfacesOfMesh(mesh),
			surface => new LazySurface(surface))
	)
	{
	}
}