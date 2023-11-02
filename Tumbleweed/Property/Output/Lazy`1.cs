using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.Literal;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Tumbleweed.Property.Output.Equality.Of.Two;
using Tumbleweed.Property.Output.With.Value;
using Tumbleweed.Property.Transput.With.Value;
using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Property.Output;

public sealed class Lazy<T> : Property::Any<T>
{
	public Lazy(T origin) : this
	(
		new Tumbleweed.Property.Output.With.Value.One<T>(origin)
	)
	{
	}
	
	public Lazy(Property::Any<T> origin) : this
	(
		origin,
		new Transput.With.Value.One<T?>(default),
		new Transput.With.Value.One<Any>(new False())
	)
	{
	}

	public Lazy
	(
		Any<T> origin,
		Transput.Any<T?> cache,
		Transput.Any<Any> cached
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
		new StringFromAnyObject(Value).Value.AsSystem;

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

	private readonly Transput.Any<T?> cache;

	private readonly Transput.Any<Any> cached;

	private readonly Any<T> origin;
}