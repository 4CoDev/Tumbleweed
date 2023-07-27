using Tumbleweed.Boolean;
using Tumbleweed.Boolean.Literal;
using Tumbleweed.Mutable;
using Tumbleweed.Mutable.Of;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Tumbleweed.Scalar.Equality.Of.Two;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Lazy;

public sealed class OfValue<T> : Scalar.Any<T>
{
	public OfValue(T origin) : this
	(
		new Scalar.Of.Value<T>(origin)
	)
	{
	}
	
	public OfValue(Scalar.Any<T> origin) : this
	(
		origin,
		new MutableValue<T?>(default),
		new MutableValue<Any>(new False())
	)
	{
	}

	public OfValue
	(
		Scalar.Any<T> origin, Mutable.Any<T?> cache, Mutable.Any<Any> cached)
	{
		this.cache = cache;
		this.cached = cached;
		this.origin = origin;
	}

	public override System::Boolean Equals(System::Object? @object) =>
		new Nullables<T>(this, @object).State;

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

	private readonly Scalar.Any<T> origin;
}