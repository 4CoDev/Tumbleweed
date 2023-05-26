using Tumbleweed._Object.String;

namespace Tumbleweed.Mutable;

public sealed class MutableValue<T> : IMutable<T>
{
	public MutableValue(T value) =>
		Value = value;

	public override String ToString() =>
		new StringFromNullableObject(Value).Value.Value;

	public T Value { get; set; }
}