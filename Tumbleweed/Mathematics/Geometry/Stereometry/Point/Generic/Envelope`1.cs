namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;

public abstract class Envelope<T> : Any<T>
{
	protected Envelope(Any<T> point) =>
		this.point = point;

	public T X => point.X;

	public T Y => point.Y;

	public T Z => point.Z;

	private readonly Any<T> point;
}