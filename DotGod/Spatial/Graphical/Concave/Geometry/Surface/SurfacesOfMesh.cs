using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Tumbleweed._Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

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