using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Mathematics.Geometry.Planimetry.Point.With.Coordinate.Definition;

public sealed class Unique<T> : Any<T>
{
	public Unique(T x, T y) : this
	(
		new Scalar::With.Value<T>(x),
		new Scalar::With.Value<T>(y)
	)
	{
	}
	
	public Unique
	(
		Scalar::Any<T> x,
		Scalar::Any<T> y
	)
	{
		this.x = x;
		this.y = y;
	}

	public T X => x.Value;

	private readonly Scalar::Any<T> x;

	public T Y => y.Value;
	
	private readonly Scalar::Any<T> y;
}