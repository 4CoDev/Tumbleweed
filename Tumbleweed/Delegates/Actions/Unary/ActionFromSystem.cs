using Tumbleweed.Hashes;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Delegates.Actions.Unary;

public class ActionFromSystem<T> : IUnaryAction<T>
{
	public ActionFromSystem(Action<T> @delegate) =>
		this.@delegate = @delegate;

	public void Invoke(T parameter) => @delegate(parameter);

	public override Boolean Equals(Object? @object) =>
	(
		@object is ActionFromSystem<T> action &&
		action.@delegate.Equals(@delegate)
	);

	public override Int32 GetHashCode() =>
		new HashOfObject(@delegate).Value;

	public override String? ToString() =>
		new NullableFromObject(@delegate).ToString();

	private readonly Action<T> @delegate;
}