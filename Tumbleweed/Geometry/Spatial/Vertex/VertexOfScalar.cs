using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace Tumbleweed.Geometry.Spatial.Vertex;

public sealed class VertexOfScalar : IVertex
{
	public VertexOfScalar(IScalar<IVertex> vertex) =>
		this.vertex = vertex;

	public IPoint<IReal> Translation =>
		vertex.Value.Translation;

	private readonly IScalar<IVertex> vertex;
}