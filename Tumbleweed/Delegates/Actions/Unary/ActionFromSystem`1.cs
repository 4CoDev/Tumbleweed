using Tumbleweed.Hashes;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Delegates.Actions.Unary;

public class ActionFromSystem<T> : IUnaryAction<T>
{
	public ActionFromSystem(Action<T> @delegate) =>
		this.@delegate = @delegate;

	public void Invoke(T parameter) => @delegate(parameter);

	private readonly Action<T> @delegate;
}