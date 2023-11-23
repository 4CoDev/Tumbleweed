using Property = Tumbleweed.Property.Output;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Property;

public sealed class Value : Any
{
	public Value(Property::Any<Any> property) =>
		this.property = property;

	public SCG::IEnumerable<Vertex.Any> Vertices =>
		property.Value.Vertices;
	
	private readonly Property::Any<Any> property;
}