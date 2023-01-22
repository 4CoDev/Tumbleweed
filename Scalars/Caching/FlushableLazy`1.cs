using Tumbleweed.References;

namespace Tumbleweed.Scalars.Caching;

public sealed class FlushableLazy<T> : IFlushable<T>
{
	public FlushableLazy(IScalar<T> scalar) : this
	(
		scalar, new ReferenceTo<T?>(default)
	)
	{
	}

	public FlushableLazy(IScalar<T> scalar, IReferenceTo<T?> value) : this
	(
		scalar, value, new ReferenceTo<bool>(false)
	)
	{
	}

	public FlushableLazy
	(
		IScalar<T> scalar,
		IReferenceTo<T?> value,
		IReferenceTo<bool> isCached
	)
	{
		lazy = new ReferenceTo<IScalar<T>>(new Lazy<T>(scalar, value, isCached));
		this.isCached = isCached;
	}

	public T Value()
	{
		return lazy.Value.Value();
	}

	public void Flush()
	{
		isCached.Value = false;
	}

	private readonly IReferenceTo<IScalar<T>> lazy;

	private readonly IReferenceTo<bool> isCached;
}