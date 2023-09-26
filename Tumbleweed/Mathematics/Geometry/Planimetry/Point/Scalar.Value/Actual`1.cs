namespace Tumbleweed.Mathematics.Geometry.Planimetry.Point.Scalar.Value;

public sealed class Actual<T> : Any<T>
{
	public Actual(Tumbleweed.Scalar.Immutable.Any<Any<T>> point) =>
		this.point = point;
	
	public T X => point.Value.X;

	public T Y => point.Value.Y;

	private readonly Tumbleweed.Scalar.Immutable.Any<Any<T>> point;
}