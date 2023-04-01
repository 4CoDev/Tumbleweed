using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Planar;

public sealed class PlanarWithValues<T> : IPlanar<T>
{
	public PlanarWithValues(T x, T y) : this
	(
		new ScalarOfValue<T>(x),
		new ScalarOfValue<T>(y)
	)
	{
	}
	
	public PlanarWithValues(IScalar<T> x, IScalar<T> y)
	{
		this.x = x;
		this.y = y;
	}

	public T X => x.Value;

	private readonly IScalar<T> x;

	public T Y => y.Value;
	
	private readonly IScalar<T> y;
}