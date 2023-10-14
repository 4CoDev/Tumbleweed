using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.Literal;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Tumbleweed.Scalar.Immutable.Equality.Of.Two;
using Tumbleweed.Scalar.Immutable.With;
using Tumbleweed.Scalar.Mutable.With.Value;
using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Scalar.Immutable;

public sealed class Lazy<T> : Immutable::Any<T>
{
	public Lazy(T origin) : this
	(
		new Value<T>(origin)
	)
	{
	}
	
	public Lazy(Immutable::Any<T> origin) : this
	(
		origin,
		new One<T?>(default),
		new One<Any>(new False())
	)
	{
	}

	public Lazy
	(
		Any<T> origin,
		Mutable.Any<T?> cache,
		Mutable.Any<Any> cached
	)
	{
		this.cache = cache;
		this.cached = cached;
		this.origin = origin;
	}

	public override System::Boolean Equals(System::Object? @object) =>
		new Equality.Of.Two.Nullable<T>(this, @object).State;

	public override Int32 GetHashCode() =>
		new ZeroHashWhenNull(Value).Value;

	public override System::String? ToString() =>
		new StringFromAnyObject(Value).Value.Value;

	public T Value
	{
		get
		{
			if (!cached.Value.State)
			{
				cache.Value = origin.Value;
				cached.Value = new True();
			}
			return cache.Value!;
		}
	}

	private readonly Mutable.Any<T?> cache;

	private readonly Mutable.Any<Any> cached;

	private readonly Any<T> origin;
}