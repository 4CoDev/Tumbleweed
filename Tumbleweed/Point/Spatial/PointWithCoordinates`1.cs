using Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial;

public sealed class PointWithCoordinates<T> : IPoint<T>
{
	public PointWithCoordinates(T x, T y, T z) : this
	(
		new ScalarValue<T>(x),
		new ScalarValue<T>(y),
		new ScalarValue<T>(z)
	)
	{
	}
	
	public PointWithCoordinates
	(
		IScalar<T> x,
		IScalar<T> y,
		IScalar<T> z
	)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}

	public T X => x.Value;

	private readonly IScalar<T> x;

	public T Y => y.Value;
	
	private readonly IScalar<T> y;

	public T Z => z.Value;
	
	private readonly IScalar<T> z;
}