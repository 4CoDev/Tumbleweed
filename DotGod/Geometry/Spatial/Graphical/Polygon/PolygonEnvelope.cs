using DotGod.Geometry.Spatial.Graphical.Vertex;

namespace DotGod.Geometry.Spatial.Graphical.Polygon;

public abstract class PolygonEnvelope : IPolygon
{
	protected PolygonEnvelope(IPolygon polygon) =>
		this.polygon = polygon;

	public override Boolean Equals(Object? @object) =>
		polygon.Equals(@object);

	public override Int32 GetHashCode() =>
		polygon.GetHashCode();

	public override String? ToString() =>
		polygon.ToString();

	public IEnumerable<IVertex> Vertices =>
		polygon.Vertices;
	
	private readonly IPolygon polygon;
}