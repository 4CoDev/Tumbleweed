using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Equality;
using System = System;

namespace Tumbleweed.Storage.Record.By.Key;

public sealed class Local : Record.Any<System::Object>
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
	
	public Local(Storage.Any storage, System::Object key)
	{
		this.storage = storage;
		this.key = key;
	}

	public Scalar.Nullable.Any<System::Object> Value =>
		storage.ValueWith(key);

	public void Remove() =>
		storage.RemoveBy(key);

	public void Place(System::Object value) =>
		storage.Add(key, value);

	private readonly Storage.Any storage;

	private readonly System::Object key;
}