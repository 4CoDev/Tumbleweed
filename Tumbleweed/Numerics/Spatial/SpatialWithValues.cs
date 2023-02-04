namespace Tumbleweed.Numerics.Spatial;

public sealed class SpatialWithValues<T> : ISpatial<T>
{
	public SpatialWithValues(T x, T y, T z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public T X { get; }

	public T Y { get; }
	
	public T Z { get; }
}