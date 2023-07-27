using Tumbleweed.Boolean;
using Tumbleweed.Boolean.Literal;

namespace Tumbleweed.Nullable;

public sealed class Null<T> : Nullable.Any<T>
{
	public T Value =>
		throw new NullReferenceException(
			"That object does not exist");

	public Any HasValue =>
		new False();
}