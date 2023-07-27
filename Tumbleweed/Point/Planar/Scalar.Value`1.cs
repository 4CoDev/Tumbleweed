using Point = Tumbleweed.Point.Planar;
using Scalar = Tumbleweed.Scalar;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Planar.Scalar;

public sealed class Value<T> : Any<T>
{
	public Value(Scalar::Any<Point::Any<T>> point) =>
		this.point = point;
	
	public T X => point.Value.X;

	public T Y => point.Value.Y;

	private readonly Scalar::Any<Point::Any<T>> point;
}