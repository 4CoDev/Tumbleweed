namespace Tumbleweed.Point.Planar;

public interface IPoint<out T>
{
	T X { get; }
	
	T Y { get; }
}