using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using Scalar = Tumbleweed.Scalar;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Geometry.Spatial.Vertex.Scalar;

public sealed class Value : Vertex::Any
{
	public Value(Scalar::Any<Vertex::Any> vertex) =>
		this.vertex = vertex;

	public Point::Any<Real::Any> Translation =>
		vertex.Value.Translation;

	private readonly Scalar::Any<Vertex::Any> vertex;
}