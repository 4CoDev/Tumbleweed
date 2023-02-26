namespace Tumbleweed.Mutables;

public interface IMutable<T>
{
	T Value { get; set; }
}