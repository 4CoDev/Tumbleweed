using Record = Tumbleweed.Storage.Record;
using System = System;
using Nullable = Tumbleweed.Nullable;

namespace Tumbleweed.Storage.Record;

public abstract class Envelope<T> : Record::Any<T> where T : notnull
{
	protected Envelope(Record::Any<T> record) =>
		this.record = record;

	public override System::Boolean Equals(System::Object? @object) =>
		record.Equals(@object);

	public override System::Int32 GetHashCode() =>
		record.GetHashCode();

	public override System::String? ToString() =>
		record.ToString();

	public Nullable::Any<T> Value =>
		record.Value;

	public void Remove() =>
		record.Remove();

	public void Place(T value) =>
		record.Place(value);
	
	private readonly Record::Any<T> record;
}