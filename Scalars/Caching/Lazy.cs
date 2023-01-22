using Tumbleweed.References;

namespace Tumbleweed.Scalars.Caching;

public sealed class Lazy<T> : IScalar<T>
{
	public Lazy(IScalar<T> scalar) : this
	(
		scalar, new ReferenceTo<T?>(default)
	)
	{
	}

	public Lazy(IScalar<T> scalar, IReferenceTo<T?> value) : this
	(
		scalar, value, new ReferenceTo<bool>(false)
	)
	{
	}

	public Lazy
	(
		IScalar<T> scalar,
		IReferenceTo<T?> value,
		IReferenceTo<bool> isCached
	)
	{
		this.scalar = scalar;
		this.value = value;
		this.isCached = isCached;
	}

	public T Value()
	{
		if (isCached.Value) Cache();
		return value.Value!;
	}

	private void Cache()
	{
		value.Value = scalar.Value();
		isCached.Value = true;
	}

	private readonly IScalar<T> scalar;

	private readonly IReferenceTo<T?> value;

	private readonly IReferenceTo<bool> isCached;
}