namespace Tumbleweed.Numerics.Spatial;

public sealed class SpatialFromValues<T> : ISpatial<T>
{
	public SpatialFromValues(T x, T y, T z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public T X { get; }

	public T Y { get; }
	
	public T Z { get; }
}