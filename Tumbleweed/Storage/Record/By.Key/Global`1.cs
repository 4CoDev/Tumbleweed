using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Equality;
using System = System;

namespace Tumbleweed.Storage.Record.By.Key;

public sealed class Global<T> : Record.Envelope<T> where T : notnull
{
	public Global(params System::Object[] keys) : this
	(
		new Equatable(keys)
	)
	{
	}

	public Global(System::Object key) : base
	(
		new Record.By.Key.Local<T>(
			new Storage.Global(),
			key)
	)
	{
	}
}