using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

public sealed class SurfacesOfMesh : Envelope<ISurface>
{
	public SurfacesOfMesh(IMesh mesh) : base
	(
		new Result<ISurface>(
			() => mesh.Surfaces)
	)
	{
	}
}