namespace Tumbleweed.Point.Spatial.Generic;

public interface Any<out T>
{
	T X { get; }
	
	T Y { get; }
	
	T Z { get; }
}