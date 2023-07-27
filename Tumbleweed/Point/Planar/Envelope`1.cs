using Point = Tumbleweed.Point.Planar;

namespace Tumbleweed.Point.Planar;

public abstract class Envelope<T> : Point::Any<T>
{
	protected Envelope(Point::Any<T> point) =>
		this.point = point;

	public T X => point.X;

	public T Y => point.Y;

	private readonly Point::Any<T> point;
}