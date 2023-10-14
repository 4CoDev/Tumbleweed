using Tumbleweed.Mathematics.Boolean;
using Immutable = Tumbleweed.Scalar.Immutable;


namespace Tumbleweed.Scalar.Nullable;

public interface Any<out T> : Immutable::Any<T>
{
	Any HasValue { get; }
}