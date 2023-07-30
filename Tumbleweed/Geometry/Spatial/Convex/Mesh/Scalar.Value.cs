using Tumbleweed.Scalar.Immutable;
using Mesh = Tumbleweed.Geometry.Spatial.Convex.Mesh;
using Scalar = Tumbleweed.Scalar;
using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Geometry.Spatial.Convex.Mesh.Scalar;

public sealed class Value : Mesh::Any
{
	public Value(Any<Mesh::Any> scalar) =>
		this.scalar = scalar;

	public SCG::IEnumerable<Vertex::Any> Vertices =>
		scalar.Value.Vertices;
	
	private readonly Any<Mesh::Any> scalar;
}