using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Mutables;

public sealed class MutableValue<T> : IMutable<T>
{
	public MutableValue(T value) =>
		Variable = value;

	public override String? ToString() =>
		new NullableFromNullable(Variable).Value;

	public T Variable { get; set; }
}