using Tumbleweed.Objects.Strings;

namespace Tumbleweed.Mutables;

public sealed class MutableValue<T> : IMutable<T>
{
	public MutableValue(T value) =>
		Value = value;

	public override String ToString() =>
		new StringFromNullableObject(Value).Value;

	public T Value { get; set; }
}