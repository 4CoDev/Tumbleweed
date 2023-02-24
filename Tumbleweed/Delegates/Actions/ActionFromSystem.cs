using Tumbleweed.HashCodes;
using Tumbleweed.Strings;

namespace Tumbleweed.Delegates.Actions;

public class ActionFromSystem : IAction
{
	public ActionFromSystem(Action @delegate) =>
		this.@delegate = @delegate;

	public void Action() => @delegate();

	public override bool Equals(object? @object) =>
	(
		@object is ActionFromSystem action &&
		action.@delegate.Equals(@delegate)
	);

	public override int GetHashCode() =>
		new HashCodeOfObject(@delegate).Value;

	public override string? ToString() =>
		new NullableFromObject(@delegate).ToString();

	private readonly Action @delegate;
}