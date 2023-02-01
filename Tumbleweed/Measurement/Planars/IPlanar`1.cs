namespace Tumbleweed.Measurement.Planars;

public interface IPlanar<out T> where T : struct
{
	T X { get; }
	
	T Y { get; }
}