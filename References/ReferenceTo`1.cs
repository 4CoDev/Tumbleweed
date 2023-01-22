namespace Tumbleweed.References;

public sealed class ReferenceTo<T> : IReferenceTo<T>
{
	public ReferenceTo(T value)
	{
		Value = value;
	}
	
	public T Value { get; set; }
}