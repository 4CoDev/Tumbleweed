namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;

public interface Any<out T>
{
	T X { get; }
	
	T Y { get; }
	
	T Z { get; }
}