using Tumbleweed.Scalar.Nullable;
using System = System;

namespace Tumbleweed.Storage;

public abstract class Envelope : Storage.Any
{
	protected Envelope(Storage.Any storage) =>
		this.storage = storage;

	public Any<System::Object> ValueWith(System::Object key) =>
		storage.ValueWith(key);

	public void Add(System::Object key, System::Object value) =>
		storage.Add(key, value);

	public void RemoveBy(System::Object key) =>
		storage.RemoveBy(key);
	
	private readonly Storage.Any storage;
}