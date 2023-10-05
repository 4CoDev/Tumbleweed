using System = System;
using SCG = System.Collections.Generic;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Polygon;

public abstract class Envelope : Any
{
	protected Envelope(Any polygon) =>
		this.polygon = polygon;

	public override System::Boolean Equals(System::Object? @object) =>
		polygon.Equals(@object);

	public override System::Int32 GetHashCode() =>
		polygon.GetHashCode();

	public override System::String? ToString() =>
		polygon.ToString();

	public SCG::IEnumerable<Graphical.Vertex.Any> Vertices =>
		polygon.Vertices;
	
	private readonly Any polygon;
}