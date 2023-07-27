using Nullable = Tumbleweed.Nullable;

namespace Tumbleweed.Storage.Record;

public interface Any<T>
{
	Nullable::Any<T> Value { get; }

	void Remove();

	void Place(T value);
}