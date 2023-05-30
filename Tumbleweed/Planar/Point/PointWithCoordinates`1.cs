using Tumbleweed.Scalar;

namespace Tumbleweed.Planar.Point;

public sealed class PointWithCoordinates<T> : IPoint<T>
{
	public PointWithCoordinates(T x, T y) : this
	(
		new ScalarValue<T>(x),
		new ScalarValue<T>(y)
	)
	{
	}
	
	public PointWithCoordinates(IScalar<T> x, IScalar<T> y)
	{
		this.x = x;
		this.y = y;
	}

	public T X => x.Value;

	private readonly IScalar<T> x;

	public T Y => y.Value;
	
	private readonly IScalar<T> y;
}