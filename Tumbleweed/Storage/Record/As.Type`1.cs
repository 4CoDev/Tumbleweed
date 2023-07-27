using Record = Tumbleweed.Storage.Record;
using System = System;
using Nullable = Tumbleweed.Nullable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Storage.Record.As;

public sealed class Type<T> : Record::Any<T> where T : notnull
{
	public Type(Record::Any<System::Object> origin) =>
		this.origin = origin;
	
	public Nullable::Any<T> Value =>
		new Nullable::As.Type<T>(origin.Value);

	public void Remove() =>
		origin.Remove();

	public void Place(T value) =>
		origin.Place(value);
	
	private readonly Record::Any<System::Object> origin;
}