using Tumbleweed.Point.Spatial.Generic;
using System = System;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Vertex;

public abstract class Envelope : Any
{
	protected Envelope(Any vertex) =>
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

	public Any<Real::Any> Translation =>
		vertex.Translation;
	
	private readonly Any vertex;
}