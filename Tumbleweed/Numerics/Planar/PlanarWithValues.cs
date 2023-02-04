namespace Tumbleweed.Numerics.Planar;

public sealed class PlanarWithValues<T> : IPlanar<T>
{
	public PlanarWithValues(T x, T y)
	{
		X = x;
		Y = y;
	}

	public T X { get; }

	public T Y { get; }
}