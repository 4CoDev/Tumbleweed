using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using System = System;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

public abstract class PolygonEnvelope : IPolygon
{
	protected PolygonEnvelope(IPolygon polygon) =>
		this.polygon = polygon;

	public override Boolean Equals(System::Object? @object) =>
		polygon.Equals(@object);

	public override Int32 GetHashCode() =>
		polygon.GetHashCode();

	public override System::String? ToString() =>
		polygon.ToString();

	public IEnumerable<IVertex> Vertices =>
		polygon.Vertices;
	
	private readonly IPolygon polygon;
}