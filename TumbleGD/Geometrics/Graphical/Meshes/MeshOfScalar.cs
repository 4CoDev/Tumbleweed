using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes;

public sealed class MeshOfScalar : IMesh
{
	public MeshOfScalar(IScalar<IMesh> scalar) =>
		this.scalar = scalar;

	public IEnumerable<ISurface> Surfaces =>
		scalar.Value.Surfaces;

	private readonly IScalar<IMesh> scalar;
}