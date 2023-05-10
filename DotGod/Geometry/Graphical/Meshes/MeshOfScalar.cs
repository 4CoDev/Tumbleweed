using DotGod.Geometry.Graphical.Surfaces;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Meshes;

public sealed class MeshOfScalar : IMesh
{
	public MeshOfScalar(IScalar<IMesh> scalar) =>
		this.scalar = scalar;

	public IEnumerable<ISurface> Surfaces =>
		scalar.Value.Surfaces;

	private readonly IScalar<IMesh> scalar;
}