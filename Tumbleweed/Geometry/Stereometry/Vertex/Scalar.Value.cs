using Tumbleweed.Geometry.Stereometry.Vertex;
using Tumbleweed.Scalar.Immutable;
using Vertex = Tumbleweed.Geometry.Stereometry.Vertex;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Geometry.Stereometry.Vertex.Scalar;

public sealed class Value : Any
{
	public Value(Any<Any> vertex) =>
		this.vertex = vertex;

	public Point.Spatial.Generic.Any<Mathematics.Number.Real.Any> Translation =>
		vertex.Value.Translation;

	private readonly Any<Any> vertex;
}