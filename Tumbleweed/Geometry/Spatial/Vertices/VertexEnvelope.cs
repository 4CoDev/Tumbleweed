using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Geometry.Spatial.Vertices;

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

	public ISpatial<IReal> Translation => vertex.Translation;
	
	private readonly IVertex vertex;
}