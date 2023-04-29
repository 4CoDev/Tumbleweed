using Tumbleweed.Booleans;
using Tumbleweed.Hashes;
using Tumbleweed.Mutables;
using Tumbleweed.Scalars.Equality;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Scalars;

public sealed class LazyValue<T> : IScalar<T>
{
	public LazyValue(T origin) : this
	(
		new ScalarValue<T>(origin)
	)
	{
	}

	public LazyValue(IScalar<T> origin) : this
	(
		origin,
		new MutableValue<T?>(default),
		new MutableValue<IBoolean>(new False())
	)
	{
	}

	public LazyValue
	(
		IScalar<T> origin,
		IMutable<T?> cache,
		IMutable<IBoolean> cached)
	{
		this.cache = cache;
		this.cached = cached;
		this.origin = origin;
	}

	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables<T>(this, @object).State;

	public override Int32 GetHashCode() =>
		new ZeroHashWhenNull(Value).Value;

	public override String? ToString() =>
		new NullableFromNullable(Value).Value;

	public T Value
	{
		get
		{
			if (!cached.Variable.State)
			{
				cache.Variable = origin.Value;
				cached.Variable = new True();
			}
			return cache.Variable!;
		}
	}

	private readonly IMutable<T?> cache;

	private readonly IMutable<IBoolean> cached;

	private readonly IScalar<T> origin;
}