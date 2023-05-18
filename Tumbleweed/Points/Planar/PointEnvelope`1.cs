namespace Tumbleweed.Points.Planar;

public abstract class PointEnvelope<T> : IPoint<T>
{
	protected PointEnvelope(IPoint<T> point) =>
		this.point = point;

	public T X => point.X;

	public T Y => point.Y;

	private readonly IPoint<T> point;
}