using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.Literal;
using Nullable = Tumbleweed.Property.Nullable;


namespace Tumbleweed.Property.Nullable;

public sealed class Null<T> : Nullable::Any<T>
{
	public T Value =>
		throw new NullReferenceException(
			"That object does not exist");

	public Any HasValue =>
		new False();
}