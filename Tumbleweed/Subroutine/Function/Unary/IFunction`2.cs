namespace Tumbleweed.Subroutine.Function.Unary;

public interface IFunction<in TParameter, out TResult>
{
	TResult ResultWith(TParameter parameter);
}