using Tumbleweed.Numerics.Decimals;

namespace Tumbleweed.Numerics.Planar;

public sealed class PlanarFromValues<T> : IPlanar<T>
{
	public PlanarFromValues(T x, T y)
	{
		X = x;
		Y = y;
	}

	public T X { get; }

	public T Y { get; }
}