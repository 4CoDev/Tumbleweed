using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Equality;
using System = System;

namespace Tumbleweed.Storage.Record.By.Key;

public sealed class Global : Record.Envelope<System::Object>
{
	public Global(params System::Object[] keys) : this
	(
		new Equatable(keys)
	)
	{
	}
	
	public Global(System::Object key) : base
	(
		new Record.By.Key.Local(
			new Storage.Global(),
			key)
	)
	{
	}
}