namespace Tumbleweed.Delegates.Actions.Unary;

public interface IUnaryAction<in T>
{
	void Invoke(T parameter);
}