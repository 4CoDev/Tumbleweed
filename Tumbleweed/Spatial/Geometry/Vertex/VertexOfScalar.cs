using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace Tumbleweed.Spatial.Geometry.Vertex;

public sealed class VertexOfScalar : IVertex
{
	public VertexOfScalar(IScalar<IVertex> vertex) =>
		this.vertex = vertex;

	public IPoint<IReal> Translation =>
		vertex.Value.Translation;

	private readonly IScalar<IVertex> vertex;
}