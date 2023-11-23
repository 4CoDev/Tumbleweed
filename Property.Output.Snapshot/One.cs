using Output = Tumbleweed.Property.Output;
using Transput = Tumbleweed.Property.Transput;
using Nullable = Tumbleweed.Property.Nullable;

namespace Tumbleweed.Property.Output.Snapshot;

public sealed class One<T> : Output::Any<T>
{
	public One(T origin) : this
	(
		new Output::With.Value.One<T>(origin)
	)
	{
	}
	
	public One(Output::Any<T> origin) : this
	(
		origin,
		new Transput::With.Value.One
			<Nullable::Any<T>>
			(new Nullable::Null<T>())
	)
	{
	}

	public One
	(
		Output::Any<T> origin,
		Transput::Any<Nullable::Any<T>> cache
	)
	{
		this.cache = cache;
		this.origin = origin;
	}

	public T Value
	{
		get
		{
			if (cache.Value.HasValue.State) return cache.Value.Value!;
			cache.Value = new Nullable::With.Value.One<T>(origin.Value);
			return cache.Value.Value;
		}
	}

	private readonly Transput::Any<Nullable::Any<T>> cache;

	private readonly Output::Any<T> origin;
}