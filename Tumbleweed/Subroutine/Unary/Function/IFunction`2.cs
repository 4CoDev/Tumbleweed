namespace Tumbleweed.Subroutine.Unary.Function;

public interface IFunction<in TParameter, out TResult>
{
	TResult ResultWith(TParameter parameter);
}