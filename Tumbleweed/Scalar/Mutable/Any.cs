using Immutable = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Scalar.Mutable;

public interface Any<T> : Immutable::Any<T>
{
	new T Value { get; set; }
}