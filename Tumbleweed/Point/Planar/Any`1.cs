namespace Tumbleweed.Point.Planar;

public interface Any<out T>
{
	T X { get; }
	
	T Y { get; }
}