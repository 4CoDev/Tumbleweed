using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Mutables;

public sealed class MutableValue<T> : IMutable<T>
{
	public MutableValue(T value) =>
		Value = value;

	public override String? ToString() =>
		new NullableFromNullable(Value).Value;

	public T Value { get; set; }
}