using Immutable = Tumbleweed.Scalar.Immutable;
using Boolean = Tumbleweed.Boolean;

namespace Tumbleweed.Scalar.Nullable;

public interface Any<out T> : Immutable::Any<T>
{
	Boolean::Any HasValue { get; }
}