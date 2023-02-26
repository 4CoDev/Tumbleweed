namespace Tumbleweed.Delegates.Functions.Unary;

public interface IUnaryFunction<in TParameter, out TResult>
{
	TResult Invoke(TParameter parameter);
}