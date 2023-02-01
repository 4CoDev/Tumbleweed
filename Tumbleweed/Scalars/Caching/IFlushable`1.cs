namespace Tumbleweed.Scalars.Caching;

public interface IFlushable<out T> : IScalar<T>
{
	void Flush();
}