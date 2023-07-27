using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using System = System;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Spatial.Vertex;

public abstract class Envelope : Vertex::Any
{
	protected Envelope(Vertex::Any vertex) =>
		this.vertex = vertex;

	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		vertex.Equals(@object)
	);

	public override System::Int32 GetHashCode() =>
		vertex.GetHashCode();

	public override System::String? ToString() =>
		vertex.ToString();

	public Point::Any<Real::Any> Translation =>
		vertex.Translation;
	
	private readonly Vertex::Any vertex;
}