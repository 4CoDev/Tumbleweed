using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometry.Spatial.Vertices;

public sealed class VertexOfScalar : IVertex
{
	public VertexOfScalar(IScalar<IVertex> vertex) =>
		this.vertex = vertex;

	public IPoint<IReal> Translation =>
		vertex.Value.Translation;

	private readonly IScalar<IVertex> vertex;
}