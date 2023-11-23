using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.Literal;
using Option = Tumbleweed.Property.Option;

namespace Tumbleweed.Property.Option;

public struct Empty<T> : Option::Any<T>
{
	public T Value =>
		throw new NullReferenceException(
			"That object does not exist");

	public Any HasValue =>
		new False();
}