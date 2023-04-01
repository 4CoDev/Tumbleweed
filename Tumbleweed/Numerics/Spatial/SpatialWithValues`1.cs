using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Spatial;

public sealed class SpatialWithValues<T> : ISpatial<T>
{
	public SpatialWithValues(T x, T y, T z) : this
	(
		new ScalarOfValue<T>(x),
		new ScalarOfValue<T>(y),
		new ScalarOfValue<T>(z)
	)
	{
	}
	
	public SpatialWithValues(IScalar<T> x, IScalar<T> y, IScalar<T> z)
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