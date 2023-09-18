using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;

public sealed class Unique<T> : Any<T>
{
	public Unique(T x, T y, T z) : this
	(
		new Scalar::With.Value<T>(x),
		new Scalar::With.Value<T>(y),
		new Scalar::With.Value<T>(z)
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