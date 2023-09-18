using Scalar = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.Scalar;

public sealed class Value : Any
{
	public Value(Scalar::Any<Any> scalar) =>
		this.scalar = scalar;

	public SCG::IEnumerable<Vertex::Any> Vertices =>
		scalar.Value.Vertices;
	
	private readonly Scalar::Any<Any> scalar;
}