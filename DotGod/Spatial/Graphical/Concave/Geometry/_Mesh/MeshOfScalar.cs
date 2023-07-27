using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

public sealed class MeshOfScalar : IMesh
{
	public MeshOfScalar(Any<IMesh> any) =>
		this.any = any;

	public IEnumerable<ISurface> Surfaces =>
		any.Value.Surfaces;

	private readonly Any<IMesh> any;
}