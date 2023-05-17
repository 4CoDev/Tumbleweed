using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Planar;

public sealed class PlanarOfScalar<T> : IPlanar<T>
{
	public PlanarOfScalar(IScalar<IPlanar<T>> scalar) =>
		this.scalar = scalar;
	
	public T X => scalar.Value.X;

	public T Y => scalar.Value.Y;

	private readonly IScalar<IPlanar<T>> scalar;
}