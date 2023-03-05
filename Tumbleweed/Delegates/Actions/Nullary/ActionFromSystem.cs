using Tumbleweed.Hashes;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Delegates.Actions.Nullary;

public class ActionFromSystem : INullaryAction
{
	public ActionFromSystem(Action @delegate) =>
		this.@delegate = @delegate;

	public void Invoke() => @delegate();

	public override Boolean Equals(Object? @object) =>
	(
		@object is ActionFromSystem action &&
		action.@delegate.Equals(@delegate)
	);

	public override Int32 GetHashCode() =>
		new CodeOfObject(@delegate).Value;

	public override String? ToString() =>
		new NullableFromObject(@delegate).ToString();

	private readonly Action @delegate;
}