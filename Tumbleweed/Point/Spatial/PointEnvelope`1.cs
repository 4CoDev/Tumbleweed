namespace Tumbleweed.Point.Spatial;

public abstract class PointEnvelope<T> : IPoint<T>
{
	protected PointEnvelope(IPoint<T> point) =>
		this.point = point;

	public T X => point.X;

	public T Y => point.Y;

	public T Z => point.Z;

	private readonly IPoint<T> point;
}