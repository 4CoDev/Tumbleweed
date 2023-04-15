namespace Tumbleweed.Mutables;

public interface IMutable<T>
{
	T Variable { get; set; }
}