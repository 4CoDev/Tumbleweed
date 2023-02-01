using Tumbleweed.Scalars;

namespace Tumbleweed.Measurement.Planars;

public sealed class PlanarFromScalar<T> : IPlanar<T> where T : struct
{
	public PlanarFromScalar(IScalar<IPlanar<T>> scalar)
	{
		this.scalar = scalar;
	}
	
	public T X
	{
		get => scalar.Value().X;
	}

	public T Y
	{
		get => scalar.Value().Y;
	}
	
	private readonly IScalar<IPlanar<T>> scalar;
}
