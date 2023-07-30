namespace Tumbleweed.Storage.Record;

public interface Any<T>
{
	Scalar.Nullable.Any<T> Value { get; }

	void Remove();

	void Place(T value);
}