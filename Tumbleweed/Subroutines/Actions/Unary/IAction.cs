namespace Tumbleweed.Subroutines.Actions.Unary;

public interface IAction<in T>
{
	void InvokeWith(T parameter);
}