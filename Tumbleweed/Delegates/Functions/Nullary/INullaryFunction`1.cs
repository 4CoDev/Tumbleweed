namespace Tumbleweed.Delegates.Functions.Nullary;

public interface INullaryFunction<out TResult>
{
	TResult Invoke();
}