namespace Tumbleweed.Points.Planar;

public interface IPoint<out T>
{
	T X { get; }
	
	T Y { get; }
}