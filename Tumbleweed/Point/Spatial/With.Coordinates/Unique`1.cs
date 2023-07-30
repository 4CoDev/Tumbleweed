using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Point = Tumbleweed.Point.Spatial;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.With.Coordinates;

public sealed class Unique<T> : Point::Any<T>
{
	public Unique(T x, T y, T z) : this
	(
		new Value<T>(x),
		new Value<T>(y),
		new Value<T>(z)
	)
	{
	}
	
	public Unique
	(Tumbleweed.Scalar.Immutable.Any<T> x, Tumbleweed.Scalar.Immutable.Any<T> y, Tumbleweed.Scalar.Immutable.Any<T> z
	)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}

	public T X => x.Value;

	private readonly Tumbleweed.Scalar.Immutable.Any<T> x;

	public T Y => y.Value;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<T> y;

	public T Z => z.Value;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<T> z;
}