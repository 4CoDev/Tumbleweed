namespace Tumbleweed.Mutable;

public sealed class ScalarValue<T> : Mutable.Any<T>
{
	public ScalarValue(Scalar.Any<Mutable.Any<T>> scalar) =>
		this.scalar = scalar;

	public T Value
	{
		get => scalar.Value.Value;
		set => scalar.Value.Value = value;
	}

	private readonly Scalar.Any<Mutable.Any<T>> scalar;
}