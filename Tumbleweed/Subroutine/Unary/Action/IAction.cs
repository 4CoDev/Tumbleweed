namespace Tumbleweed.Subroutine.Unary.Action;

public interface IAction<in T>
{
	void InvokeWith(T parameter);
}