using Tumbleweed.Scalar.Nullable;
using System = System;

namespace Tumbleweed.Storage;

public sealed class Global : Storage.Any
{
	static Global() =>
		Storage = new Empty();

	public Any<System::Object> ValueWith(System::Object key) =>
		Storage.ValueWith(key);

	public void Add(System::Object key, System::Object value) =>
		Storage.Add(key, value);
	
	public void RemoveBy(System::Object key) =>
		Storage.RemoveBy(key);
	
	private static readonly Storage.Any Storage;
}