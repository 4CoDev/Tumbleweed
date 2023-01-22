namespace Tumbleweed.References;

public interface IReferenceTo<T>
{
	T Value { get; set; }
}