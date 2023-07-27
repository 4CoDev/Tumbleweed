using Point = Tumbleweed.Point.Spatial;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.With.Coordinates;

public sealed class Unique<T> : Point::Any<T>
{
	public Unique(T x, T y, T z) : this
	(
		new Scalar::Of.Value<T>(x),
		new Scalar::Of.Value<T>(y),
		new Scalar::Of.Value<T>(z)
	)
	{
	}
	
	public Unique
	(
		Scalar::Any<T> x,
		Scalar::Any<T> y,
		Scalar::Any<T> z
	)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}

	public T X => x.Value;

	private readonly Scalar::Any<T> x;

	public T Y => y.Value;
	
	private readonly Scalar::Any<T> y;

	public T Z => z.Value;
	
	private readonly Scalar::Any<T> z;
}