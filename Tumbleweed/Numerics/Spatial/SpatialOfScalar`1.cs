using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Spatial;

public sealed class SpatialOfScalar<T> : ISpatial<T>
{
	public SpatialOfScalar(IScalar<ISpatial<T>> scalar) =>
		this.scalar = scalar;
	
	public T X => scalar.Value.X;

	public T Y => scalar.Value.Y;

	public T Z => scalar.Value.Z;

	private readonly IScalar<ISpatial<T>> scalar;
}