namespace Tumbleweed.Delegates.Functions.Binary;

public interface IBinaryFunction<in TFirst, in TSecond, out TResult>
{
	TResult Invoke(TFirst first, TSecond second);
}