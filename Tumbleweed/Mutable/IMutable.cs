namespace Tumbleweed.Mutable;

public interface IMutable<T>
{
	T Value { get; set; }
}