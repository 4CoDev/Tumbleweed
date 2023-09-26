using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Scalar = Tumbleweed.Scalar.Immutable;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;
using Real = Tumbleweed.Mathematics.Number.Real;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Scalar;

public sealed class Value : Any
{
	public Value(Scalar::Any<Any> vertex) =>
		this.vertex = vertex;

	public Any<Real::Any> Translation =>
		vertex.Value.Translation;

	private readonly Scalar::Any<Any> vertex;
}