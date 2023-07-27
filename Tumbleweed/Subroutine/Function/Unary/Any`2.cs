namespace Tumbleweed.Subroutine.Function.Unary;

public interface Any<in TParameter, out TResult>
{
	TResult ResultWith(TParameter parameter);
}