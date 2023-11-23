namespace Tumbleweed.Subroutine.Function.Binary;

public interface Any<in T1, in T2, out TResult>
{
	TResult ResultWith(T1 first, T2 second);
}