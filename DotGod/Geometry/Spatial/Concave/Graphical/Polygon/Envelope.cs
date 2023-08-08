using Polygon = DotGod.Geometry.Spatial.Concave.Graphical.Polygon;
using System = System;
using SCG = System.Collections.Generic;
using Vertex = DotGod.Geometry.Spatial.Concave.Graphical.Vertex;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Polygon;

public abstract class Envelope : Polygon::Any
{
	protected Envelope(Polygon::Any polygon) =>
		this.polygon = polygon;

	public override System::Boolean Equals(System::Object? @object) =>
		polygon.Equals(@object);

	public override System::Int32 GetHashCode() =>
		polygon.GetHashCode();

	public override System::String? ToString() =>
		polygon.ToString();

	public SCG::IEnumerable<Vertex::Any> Vertices =>
		polygon.Vertices;
	
	private readonly Polygon::Any polygon;
}