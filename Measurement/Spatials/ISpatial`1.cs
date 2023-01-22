namespace Tumbleweed.Measurement.Spatials;

public interface ISpatial<out T> where T : struct
{
	public static Spatial<T> operator *(ISpatial<T> left, ISpatial<T> right)
	{
		return new Spatial<T>(
			(dynamic) left.X * right.X,
			(dynamic) left.Y * right.Y,
			(dynamic) left.Z * right.Z);
	}
	
	public static Spatial<T> operator /(ISpatial<T> left, ISpatial<T> right)
	{
		return new Spatial<T>(
			(dynamic) left.X / right.X,
			(dynamic) left.Y / right.Y,
			(dynamic) left.Z / right.Z);
	}

	T X { get; }
	
	T Y { get; }
	
	T Z { get; }
}