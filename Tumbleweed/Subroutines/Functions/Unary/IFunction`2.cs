namespace Tumbleweed.Subroutines.Functions.Unary;

public interface IFunction<in TParameter, out TResult>
{
	TResult ResultWith(TParameter parameter);
}