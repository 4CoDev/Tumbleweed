using DotGod.Geometry.Spatial.Graphical._Mesh;
using Tumbleweed._Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.Surface;

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