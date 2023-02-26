namespace Tumbleweed.Mutables;

public sealed class MutableWithValue<T> : IMutable<T>
{
	public MutableWithValue(T value) => Value = value;
	
	public T Value { get; set; }
}