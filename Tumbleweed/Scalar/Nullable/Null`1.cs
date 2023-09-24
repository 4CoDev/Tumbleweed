using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.Literal;
using Nullable = Tumbleweed.Scalar.Nullable;
using Boolean = Tumbleweed.Boolean;

namespace Tumbleweed.Scalar.Nullable;

public sealed class Null<T> : Nullable::Any<T>
{
	public T Value =>
		throw new NullReferenceException(
			"That object does not exist");

	public Any HasValue =>
		new False();
}