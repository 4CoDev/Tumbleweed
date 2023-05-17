namespace Tumbleweed.Points.Planar;

public interface IPlanar<out T>
{
	T X { get; }
	
	T Y { get; }
}