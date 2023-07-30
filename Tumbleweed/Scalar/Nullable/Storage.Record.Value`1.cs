using Nullable = Tumbleweed.Scalar.Nullable;
using Record = Tumbleweed.Storage.Record;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Nullable.Storage.Record;

public sealed class Value<T> : Nullable::Envelope<T>
{
	public Value
	(
		Record::Any<Nullable::Any<T>> record
	) : base
	(
		new Nullable::Scalar.Value.One<T>(
			new Record::Value.NonNullable<Nullable::Any<T>>(record))
	)
	{
	}
}