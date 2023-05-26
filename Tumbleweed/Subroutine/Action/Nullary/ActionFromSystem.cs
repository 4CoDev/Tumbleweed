namespace Tumbleweed.Subroutine.Action.Nullary;

public class ActionFromSystem : IAction
{
	public ActionFromSystem(System.Action function) =>
		this.function = function;

	public void Invoke() => function();

	private readonly System.Action function;
}