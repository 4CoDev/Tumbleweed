using Point = Tumbleweed.Point.Spatial;
using Scalar = Tumbleweed.Scalar;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Spatial.Scalar;

public sealed class Value<T> : Point::Any<T>
{
	public Value(Tumbleweed.Scalar.Immutable.Any<Point::Any<T>> scalar) =>
		this.scalar = scalar;
	
	public T X => scalar.Value.X;

	public T Y => scalar.Value.Y;

	public T Z => scalar.Value.Z;

	private readonly Tumbleweed.Scalar.Immutable.Any<Point::Any<T>> scalar;
}