using Tumbleweed.Scalar;

namespace Tumbleweed.Spatial.Point;

public sealed class PointOfScalar<T> : IPoint<T>
{
	public PointOfScalar(IScalar<IPoint<T>> scalar) =>
		this.scalar = scalar;
	
	public T X => scalar.Value.X;

	public T Y => scalar.Value.Y;

	public T Z => scalar.Value.Z;

	private readonly IScalar<IPoint<T>> scalar;
}