using Point = Tumbleweed.Point.Spatial;

namespace Tumbleweed.Point.Spatial;

public abstract class Envelope<T> : Point::Any<T>
{
	protected Envelope(Point::Any<T> point) =>
		this.point = point;

	public T X => point.X;

	public T Y => point.Y;

	public T Z => point.Z;

	private readonly Point::Any<T> point;
}