using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

public sealed class MeshOfScalar : IMesh
{
	public MeshOfScalar(IScalar<IMesh> scalar) =>
		this.scalar = scalar;

	public IEnumerable<ISurface> Surfaces =>
		scalar.Value.Surfaces;

	private readonly IScalar<IMesh> scalar;
}