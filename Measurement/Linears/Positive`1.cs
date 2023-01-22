using Tumbleweed.Scalars;

namespace Tumbleweed.Measurement.Linears;

public readonly record struct Positive<T> : IScalar<T>
	where T : struct
{
	public Positive() : this((T)(dynamic) 0)
	{
	}

	public Positive(T value)
	{
		this.value = value;
	}

	public T Value()
	{
		if ((dynamic) value >= 0) return value;
		const string message = "Value must be positive.";
		throw new ArgumentOutOfRangeException(nameof(value), value, message);
	}
	
	public static implicit operator T(Positive<T> positive)
	{
		return positive.value;
	}

	private readonly T value;
}