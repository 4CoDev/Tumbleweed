using Godot;

namespace Tumbleweed.Measurement.Planars;

public sealed class Planar<T> : IPlanar<T> where T : struct
{
	public static explicit operator Vector2(Planar<T> planar)
	{
		return new Vector2(
			(dynamic) planar.X,
			(dynamic) planar.Y);
	}
	
	public static explicit operator Planar<T>(Vector3 vector3)
	{
		return new Planar<T>(
			(T)(dynamic) vector3.x,
			(T)(dynamic) vector3.y);
	}

	public Planar() : this
	(
		(T)(dynamic) 0,
		(T)(dynamic) 0
	)
	{
	}
	
	public Planar(T x, T y)
	{
		X = x;
		Y = y;
	}
	
	public T X { get; }

	public T Y { get; }
}