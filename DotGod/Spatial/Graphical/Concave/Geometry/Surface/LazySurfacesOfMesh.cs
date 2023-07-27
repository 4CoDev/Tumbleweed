using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Tumbleweed.Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

public sealed class LazySurfacesOfMesh : Envelope<ISurface>
{
	public LazySurfacesOfMesh(IMesh mesh) : base
	(
		new Tumbleweed.Enumerable.Lazy.Selected<ISurface>(
			new SurfacesOfMesh(mesh),
			surface => new LazySurface(surface))
	)
	{
	}
}