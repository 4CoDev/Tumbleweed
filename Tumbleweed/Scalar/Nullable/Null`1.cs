using Nullable = Tumbleweed.Scalar.Nullable;
using Boolean = Tumbleweed.Boolean;
using Literal = Tumbleweed.Boolean.Literal;

namespace Tumbleweed.Scalar.Nullable;

public sealed class Null<T> : Nullable::Any<T>
{
	public T Value =>
		throw new NullReferenceException(
			"That object does not exist");

	public Boolean::Any HasValue =>
		new Literal::False();
}