namespace Tumbleweed.Subroutine.Action.Unary;

public interface IAction<in T>
{
	void InvokeWith(T parameter);
}