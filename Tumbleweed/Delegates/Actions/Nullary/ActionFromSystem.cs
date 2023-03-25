using Tumbleweed.Hashes;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Delegates.Actions.Nullary;

public class ActionFromSystem : INullaryAction
{
	public ActionFromSystem(Action function) =>
		this.function = function;

	public void Invoke() => function();

	public override Boolean Equals(Object? @object) =>
	(
		@object is ActionFromSystem action &&
		action.function.Equals(function)
	);

	public override Int32 GetHashCode() =>
		new HashOfObject(function).Value;

	public override String? ToString() =>
		new NullableFromObject(function).ToString();

	private readonly Action function;
}