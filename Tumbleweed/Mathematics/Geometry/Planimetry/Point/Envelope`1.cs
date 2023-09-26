namespace Tumbleweed.Mathematics.Geometry.Planimetry.Point;

public abstract class Envelope<T> : Any<T>
{
	protected Envelope(Any<T> point) =>
		this.point = point;

	public T X => point.X;

	public T Y => point.Y;

	private readonly Any<T> point;
}