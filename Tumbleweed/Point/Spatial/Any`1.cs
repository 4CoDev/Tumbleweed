namespace Tumbleweed.Point.Spatial;

public interface Any<out T>
{
	T X { get; }
	
	T Y { get; }
	
	T Z { get; }
}