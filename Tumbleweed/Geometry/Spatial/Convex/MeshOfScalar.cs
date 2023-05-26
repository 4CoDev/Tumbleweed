using Tumbleweed.Geometry.Spatial.Vertex;
using Tumbleweed.Scalar;

namespace Tumbleweed.Geometry.Spatial.Convex;

public sealed class MeshOfScalar : IMesh
{
	public MeshOfScalar(IScalar<IMesh> scalar) =>
		this.scalar = scalar;

	public IEnumerable<IVertex> Vertices =>
		scalar.Value.Vertices;
	
	private readonly IScalar<IMesh> scalar;
}