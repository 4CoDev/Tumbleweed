// ReSharper disable once CheckNamespace
namespace Tumbleweed.Storage.Record.Of;

public sealed class Scalar<T> : Record.Any<T> where T : notnull
{
	public Scalar(Scalar.Any<Record.Any<T>> scalar) =>
		this.scalar = scalar;
	
	public Nullable.Any<T> Value =>
		scalar.Value.Value;

	public void Remove() =>
		scalar.Value.Remove();

	public void Place(T value) =>
		scalar.Value.Place(value);
	
	private readonly Scalar.Any<Record.Any<T>> scalar;
}