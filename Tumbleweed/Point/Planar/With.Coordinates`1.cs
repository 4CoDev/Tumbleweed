using Scalar = Tumbleweed.Scalar;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Planar.With;

public sealed class Coordinates<T> : Any<T>
{
	public Coordinates(T x, T y) : this
	(
		new Scalar::Of.Value<T>(x),
		new Scalar::Of.Value<T>(y)
	)
	{
	}
	
	public Coordinates(Scalar::Any<T> x, Scalar::Any<T> y)
	{
		this.x = x;
		this.y = y;
	}

	public T X => x.Value;

	private readonly Scalar::Any<T> x;

	public T Y => y.Value;
	
	private readonly Scalar::Any<T> y;
}