using Scalar = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex.Scalar;

public sealed class Value : Any
{
	public Value(Scalar::Any<Any> scalar) =>
		this.scalar = scalar;

	public SCG::IEnumerable<Vertex.Any> Vertices =>
		scalar.Value.Vertices;
	
	private readonly Scalar::Any<Any> scalar;
}