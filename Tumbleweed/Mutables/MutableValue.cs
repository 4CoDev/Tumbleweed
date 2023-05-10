using Tumbleweed.Objects.Strings;

namespace Tumbleweed.Mutables;

public sealed class MutableValue<T> : IMutable<T>
{
	public MutableValue(T value) =>
		Variable = value;

	public override String ToString() =>
		new StringFromNullableObject(Variable).Value;

	public T Variable { get; set; }
}