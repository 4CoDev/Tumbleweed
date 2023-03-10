namespace Tumbleweed.Numerics.Spatial;

public interface ISpatial<out T>
{
	T X { get; }
	
	T Y { get; }
	
	T Z { get; }
}