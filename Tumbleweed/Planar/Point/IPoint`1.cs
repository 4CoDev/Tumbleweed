namespace Tumbleweed.Planar.Point;

public interface IPoint<out T>
{
	T X { get; }
	
	T Y { get; }
}