namespace Tumbleweed.Subroutine.Binary.Function;

public interface IFunction<in T1, in T2, out TResult>
{
	TResult ResultWith(T1 first, T2 second);
}