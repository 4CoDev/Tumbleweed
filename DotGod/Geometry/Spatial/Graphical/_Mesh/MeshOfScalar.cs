using DotGod.Geometry.Spatial.Graphical.Surface;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Mesh;

public sealed class MeshOfScalar : IMesh
{
	public MeshOfScalar(IScalar<IMesh> scalar) =>
		this.scalar = scalar;

	public IEnumerable<ISurface> Surfaces =>
		scalar.Value.Surfaces;

	private readonly IScalar<IMesh> scalar;
}