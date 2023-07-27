using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Equality;
using System = System;

namespace Tumbleweed.Storage.Record.By.Key;

public sealed class Local<T> : Record.Envelope<T> where T : notnull
{
	public Local
	(
		Storage.Any storage,
		params System::Object[] keys
	) : this
	(
		storage,
		new Equatable(keys)
	)
	{
	}
	
	public Local(Storage.Any storage, System::Object key) : base
	(
		new Record.As.Type<T>(
			new Record.By.Key.Local(storage, key))
	)
	{
	}
}