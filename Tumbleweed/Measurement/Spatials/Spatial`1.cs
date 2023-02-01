using Godot;

namespace Tumbleweed.Measurement.Spatials;

public readonly record struct Spatial<T> : ISpatial<T> where T : struct
{
	public static explicit operator Vector3(Spatial<T> spatial)
	{
		return new Vector3(
			(dynamic) spatial.X,
			(dynamic) spatial.Y,
			(dynamic) spatial.Z);
	}
	
	public static explicit operator Spatial<T>(Vector3 vector3)
	{
		return new Spatial<T>(
			(T)(dynamic) vector3.x,
			(T)(dynamic) vector3.y,
			(T)(dynamic) vector3.z);
	}

	public Spatial() : this
	(
		(T)(dynamic) 0,
		(T)(dynamic) 0,
		(T)(dynamic) 0
	)
	{
	}
	
	public Spatial(T x, T y, T z)
	{
		X = x;
		Y = y;
		Z = z;
	}
	
	public T X { get; }
	
	public T Y { get; }
	
	public T Z { get; }
}