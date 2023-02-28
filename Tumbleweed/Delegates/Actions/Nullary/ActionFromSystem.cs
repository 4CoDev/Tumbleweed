using Tumbleweed.Hashes;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Delegates.Actions.Nullary;

public class ActionFromSystem : INullaryAction
{
	public ActionFromSystem(Action @delegate) =>
		this.@delegate = @delegate;

	public void Invoke() => @delegate();

	public override bool Equals(object? @object) =>
	(
		@object is ActionFromSystem action &&
		action.@delegate.Equals(@delegate)
	);

	public override int GetHashCode() =>
		new CodeOfObject(@delegate).Value;

	public override string? ToString() =>
		new NullableFromObject(@delegate).ToString();

	private readonly Action @delegate;
}