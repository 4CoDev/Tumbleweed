using DotGod.Geometry.Spatial.Graphical._Mesh;
using Tumbleweed._Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.Surface;

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