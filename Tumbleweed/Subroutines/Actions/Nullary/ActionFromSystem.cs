namespace Tumbleweed.Subroutines.Actions.Nullary;

public class ActionFromSystem : IAction
{
	public ActionFromSystem(Action function) =>
		this.function = function;

	public void Invoke() => function();

	private readonly Action function;
}