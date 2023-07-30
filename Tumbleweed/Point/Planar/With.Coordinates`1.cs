using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Scalar = Tumbleweed.Scalar;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Planar.With;

public sealed class Coordinates<T> : Any<T>
{
	public Coordinates(T x, T y) : this
	(
		new Value<T>(x),
		new Value<T>(y)
	)
	{
	}
	
	public Coordinates(Tumbleweed.Scalar.Immutable.Any<T> x, Tumbleweed.Scalar.Immutable.Any<T> y)
	{
		this.x = x;
		this.y = y;
	}

	public T X => x.Value;

	private readonly Tumbleweed.Scalar.Immutable.Any<T> x;

	public T Y => y.Value;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<T> y;
}