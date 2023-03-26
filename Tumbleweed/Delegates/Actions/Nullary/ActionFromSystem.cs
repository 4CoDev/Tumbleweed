using Tumbleweed.Hashes;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Delegates.Actions.Nullary;

public class ActionFromSystem : INullaryAction
{
	public ActionFromSystem(Action function) =>
		this.function = function;

	public void Invoke() => function();

	private readonly Action function;
}