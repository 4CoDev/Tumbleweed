using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace Tumbleweed.Geometry.Spatial.Vertex;

public abstract class VertexEnvelope : IVertex
{
	protected VertexEnvelope(IVertex vertex) =>
		this.vertex = vertex;

	public override Boolean Equals(Object? @object) =>
		vertex.Equals(@object);

	public override Int32 GetHashCode() =>
		vertex.GetHashCode();

	public override String? ToString() =>
		vertex.ToString();

	public IPoint<IReal> Translation => vertex.Translation;
	
	private readonly IVertex vertex;
}