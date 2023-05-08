namespace Tumbleweed.Delegates.Actions.Unary;

public interface IAction<in T>
{
	void InvokeWith(T parameter);
}