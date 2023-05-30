using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Geometry.Vertex;

namespace Tumbleweed.Spatial.Convex.Geometry.Mesh;

public sealed class MeshOfScalar : IMesh
{
	public MeshOfScalar(IScalar<IMesh> scalar) =>
		this.scalar = scalar;

	public IEnumerable<IVertex> Vertices =>
		scalar.Value.Vertices;
	
	private readonly IScalar<IMesh> scalar;
}